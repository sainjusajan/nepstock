using Microsoft.Extensions.Options;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication.Core.Domains;
using WebApplication.Core.Domains.NepSE;
using WebApplication.Identity;

namespace WebApplication.Infrastructure
{
    public class ApplicationDbContext : IdentityDatabaseContext<IdentityUser, IdentityRole, string>
    {
        public string NewsCollectionName { get; set; } =    "News";
        public string CareersCollectionName { get; set; } = "Careers";

        public string StockDataCollectionName { get; set; } ="stock";

        public string PredictionCollectionName { get; set; } = "prediction";


        public virtual IMongoCollection<Prediction> Prediction
        {
            get
            {
                if (_PredictionCollection == null)
                {
                    if (string.IsNullOrWhiteSpace(PredictionCollectionName))
                    {

                    }

                    _PredictionCollection = Database.GetCollection<Prediction>(PredictionCollectionName, CollectionSettings);
                }
                return _PredictionCollection;
            }
            set { _PredictionCollection = value; }
        }
        private IMongoCollection<Prediction> _PredictionCollection;



        public virtual IMongoCollection<News> News
        {
            get
            {
                if (_newsCollection == null)
                {
                    if (string.IsNullOrWhiteSpace(NewsCollectionName))
                    {

                    }

                    _newsCollection = Database.GetCollection<News>(NewsCollectionName, CollectionSettings);
                }
                return _newsCollection;
            }
            set { _newsCollection = value; }
        }
        private IMongoCollection<News> _newsCollection;
        
        public virtual IMongoCollection<Careers> Careers
        {
            get
            {
                if (_CareersCollection == null)
                {
                    if (string.IsNullOrWhiteSpace(CareersCollectionName))
                    {

                    }

                    _CareersCollection = Database.GetCollection<Careers>(CareersCollectionName, CollectionSettings);
                }
                return _CareersCollection;
            }
            set { _CareersCollection = value; }
        }
        private IMongoCollection<Careers> _CareersCollection;

        public virtual IMongoCollection<StockData> StockData
        {
            get
            {
                if (_StockDataCollection == null)
                {
                    if (string.IsNullOrWhiteSpace(StockDataCollectionName))
                    {
                        throw new NullReferenceException();
                    }

                    _StockDataCollection = Database.GetCollection<StockData>(StockDataCollectionName, CollectionSettings);
                }
                return _StockDataCollection;
            }
            set { _StockDataCollection = value; }
        }
        private IMongoCollection<StockData> _StockDataCollection;


    }
}
