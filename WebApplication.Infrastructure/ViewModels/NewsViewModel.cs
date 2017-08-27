using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication.Infrastructure.ViewModels
{
    public class NewsViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public string Content { get; set; }
        public string AddedBy { get; set; }
        public DateTime PublishDate { get; set; }
    }
}
