using System;
using System.Collections.Generic;
using System.Text;

namespace WebApplication.Core.Domains
{
    public class Company
    {
        public string CompanyName { get; set; }
        public string CompanyAbbr { get; set; }
        public string Date { get; set; }
        public double Open { get; set; }
        public double High { get; set; }
        public double Low { get; set; }
        public double Close { get; set; }
        public double AdjClose { get; set; }
        public double Volume { get; set; }
    }
}
