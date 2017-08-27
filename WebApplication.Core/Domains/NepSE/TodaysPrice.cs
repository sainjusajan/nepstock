using System;
using System.Collections.Generic;
using System.Text;

namespace WebApplication.Core.Domains.NepSE
{
    public class TodaysPrice
    {
        //datetime

        public string TradedCompanies { get; set; }
        public int NoOfTransactions { get; set; }
        public int MaxPrice { get; set; }
        public int MinPrice { get; set; }
        public int ClosingPrice { get; set; }
        public int Shares { get; set; }
        public int Amount { get; set; }
        public int PreviousClosing { get; set; }
        public int Difference { get; set; }

    }
}
