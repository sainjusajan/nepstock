using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication.Core.Domains
{
    public class News : BaseEntity
    {        
        [Required]
        public string Title { get; set; }
        [Required]
        public string Body { get; set; }

        public DateTime publishedDate { get; set; }

        //[DataType(DataType.ImageUrl)]
        //public string ImageUrl { get; set; }

        public string addedBy { get; set; }
    }
}
