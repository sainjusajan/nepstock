using System;
using System.Collections.Generic;
using System.Text;

namespace WebApplication.Core.Domains.NepSE
{
    public class TradeBySector
    {


        public string SectorType { get; set; } //it may be enum or class type


        public int SN { get; set; }
        public string CompanyName { get; set; }
        public string Symbool { get; set; }
        public int NoOfListedShares { get; set; }
        public int PaidUpPerShare { get; set; }
        public decimal PaidUpCapital { get; set; }
        public int TradedShareQuantity { get; set; }
        public decimal TradedAmount { get; set; }
        public int NoOfTrades { get; set; }
        public int High { get; set; }
        public int Low { get; set; }
        public decimal Close { get; set; }
        public decimal Average { get; set; }
        public int NoOfTradingDays { get; set; }
        public decimal MarketCapitalisation { get; set; }

    }
}
