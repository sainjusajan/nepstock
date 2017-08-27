using System;
using System.Collections.Generic;
using System.Text;

namespace WebApplication.Core.Domains.NepSE
{
    public class ClosingPriceMovement
    {
        public string SectorType { get; set; }
        public string CompanyName { get; set; }
        public decimal PreviousMonthClosingPrice { get; set; }
        public decimal CurrentMonthClosingPrice { get; set; }
        public decimal Diference { get; set; }

    }
}
