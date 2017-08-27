using System;
using System.Collections.Generic;
using System.Text;

namespace WebApplication.Core.Domains.NepSE
{
    public class Listing
    {
        public int SN { get; set; }
        public string Type { get; set; }
        public string CompanyName { get; set; }
        public decimal ShareUnit { get; set; }
        public DateTime ListedDate { get; set; }
    }
}
