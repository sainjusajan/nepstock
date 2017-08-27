using System;
using System.Collections.Generic;
using System.Text;

namespace WebApplication.Core.Domains.NepSE
{
    public class SensitiveMarketCapitalizationBySector
    {
        public int SN { get; set; }
        public DateTime Date { get; set; }
        public decimal CommericalBank { get; set; }
        public decimal DevelopmentBank { get; set; }
        public decimal Finance { get; set; }
        public decimal Hotels { get; set; }
        public decimal HydroPower { get; set; }
        public decimal Insurance { get; set; }
        public decimal ManufacturingandProcessing { get; set; }
        public decimal Trading { get; set; }
        public decimal Others { get; set; }

        public decimal Total { get; set; }
    }
}
