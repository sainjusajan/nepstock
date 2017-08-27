using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Rewrite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication.Infrastructure.Extensions
{
    public static class ApplicationBuilderExtensions
    {
        public static IApplicationBuilder UseCustomRewriter(this IApplicationBuilder app)
        {
            var options = new RewriteOptions()
                 .AddRedirect("^(www\\.)(.*)", "$2");
            
            
            return app.UseRewriter(options);
        }
    }
}
