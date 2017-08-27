using System;
using System.Collections.Generic;
using System.Text;

namespace WebApplication.Core.Domains.NepSE
{
    public class Index
    {
        public int SN { get; set; }
        public DateTime Date { get; set; }
        public decimal Banking { get; set; }
        public decimal DevelopmentBank { get; set; }
        public decimal Finance { get; set; }
        public decimal Hotels { get; set; }
        public decimal HydroPower { get; set; }
        public decimal Insurance { get; set; }
        public decimal ManufacturingandProcessing { get; set; }
        public decimal Trading { get; set; }
        public decimal Others { get; set; }
        public decimal Float { get; set; }
        public decimal SensitiveFloat { get; set; }
        public decimal Sensitive { get; set; }
        public decimal Nepse { get; set; }

    }
}
