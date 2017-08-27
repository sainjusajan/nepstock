using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using WebApplication.Identity;

namespace WebApplication.Helpers
{
 

    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection RegisterServices(
            this IServiceCollection services)
        {
            //services.AddTransient<IMongoDbManager, MongoDbManager>();
                      
            return services;
        }
        
    }

}

