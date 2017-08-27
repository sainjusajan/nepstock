using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System.Net.Http.Headers;
using WebApplication.Core.Domains;

namespace WebApplication.Controllers
{
    public class MyWatchlistController : Microsoft.AspNetCore.Mvc.Controller
    {
        //identiy ko list ko file selected garne 

        static HttpClient client = new HttpClient();
        public IActionResult Index()
        {
             HttpClient stockData = new HttpClient();
            stockData.BaseAddress = new Uri("http://nepstock.ml/stock_api/stock_data/");
            stockData.DefaultRequestHeaders.Accept.Clear();
            stockData.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            return View();
        }

        static async Task RunAsync()
        {
            // New code:
            client.BaseAddress = new Uri("http://localhost:55268/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            Console.ReadLine();
        }

        //static async Task<StockDataPoint> GetProductAsync(string path)
        //{
        //    StockDataPoint stock = null;
        //    HttpResponseMessage response = await client.GetAsync(path);
        //    if (response.IsSuccessStatusCode)
        //    {
        //        stock = await response.Content
        //    }
        //    return stock;
        //}
    }
}