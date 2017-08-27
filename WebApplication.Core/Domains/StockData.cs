using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication.Core.Domains
{
    public class StockData //: BaseEntity
    {
        public ObjectId _id { get; set; }
        public string CompanyName { get; set; }
        public string CompanyAbbr { get; set; }
        public DateTime Date { get; set; }
        public string Open { get; set; }
        public string High { get; set; }
        public string Low { get; set; }
        public string Close { get; set; }
        public string AdjClose { get; set; }
        public string Volume { get; set; }

    }
}
