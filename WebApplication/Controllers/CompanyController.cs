using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using Newtonsoft.Json;
using WebApplication.Core.Domains;

namespace WebApplication.Controllers
{
    public class CompanyController : Controller
    {
        private static IList<Company> _companys;
        private string url = "http://nepstock.ml/stock_data/?company_abbr=RUT";

        public CompanyController(List<Company> companys)
        {
            _companys = companys;
            Task.Run(() => this.LoadDataAsync(url));
        }
        private async Task LoadDataAsync(string url)
        {
            if (_companys != null)
            {
                string responseString = null;
                using (var httpClient = new HttpClient())
                {
                    try
                    {
                        HttpResponseMessage response = await httpClient.GetAsync(url);
                        responseString = await response.Content.ReadAsStringAsync();
                        _companys = JsonConvert.DeserializeObject<List<Company>>(responseString);
                    }
                    catch (Exception ex)
                    {

                    }
                }
            }
        }

        private async Task<ActionResult> Index()
        {
            var companys =
                from company in _companys
                select company;
            return View();
            //return ViewBag("this is company page");
        }
    }
}
