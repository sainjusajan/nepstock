﻿using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication.Core.Domains
{
    public class BaseEntity
    {    
        //public string Id { get; set; } = Guid.NewGuid().ToString();
        public BsonObjectId Id { get; set; }

    }
}
