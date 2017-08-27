using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using AutoMapper;
using WebApplication.Identity;
using WebApplication.Infrastructure;
using Microsoft.AspNetCore.Http;
using WebApplication.Infrastructure.Services;
using WebApplication.Infrastructure.ViewModels;
using WebApplication.Infrastructure.Interface.Services;
using WebMarkupMin.AspNetCore1;
using WebApplication.Helpers;
using WebApplication.Infrastructure.Extensions;
using Newtonsoft.Json.Serialization;
using WebApplication.Infrastructure.Repository;

namespace WebApplication
{
    public class Startup
    {

        public Startup(IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true)
                .AddEnvironmentVariables();
            Configuration = builder.Build();

            _env = env;
            MapperConfiguration = new MapperConfiguration(cfg =>
            {   
                cfg.AddProfile(new MappingProfile());
            });


        }

        public IConfigurationRoot Configuration { get; }

        public IHostingEnvironment _env;
        public MapperConfiguration MapperConfiguration { get; set; }


        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddIdentity<IdentityUser, IdentityRole>()
                .AddMongoDBIdentityStores<ApplicationDbContext, IdentityUser, IdentityRole, string>(options =>
            {
                options.ConnectionString = Configuration["Data:DefaultConnection:ConnectionString"];
            })
           .AddDefaultTokenProviders();

            services
         .AddMvc()
         .AddJsonOptions(options => options.SerializerSettings.ContractResolver = new DefaultContractResolver());


            //services.AddKendo();

            services.AddSingleton<UserStore<IdentityUser, IdentityRole>>();

            //services.AddSingleton<IMongoDbManager, MongoDbManager>();
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddTransient<IEmailSender, AuthMessageSender>();
            services.AddTransient<ISmsSender, AuthMessageSender>();
            services.AddSingleton<IViewModelService, ViewModelService>();
            services.AddSingleton<DashboardViewModel, DashboardViewModel>();
            services.AddSingleton<SeedDataHelper>();
            services.AddMvc();

            services.AddAutoMapper(typeof(Startup));

            services.AddSingleton(sp => MapperConfiguration.CreateMapper());


            services.AddSingleton<INewsRepository, NewsRepository>();
            services.AddSingleton<ICareersRepository, CareersRepository>();
            //services.AddSingleton<IStockDataRepository, StockDataRepository>();
            services.AddSingleton<IPredictionRepository, PredictionRepository>();

            services.AddWebMarkupMin(
        options =>
        {
            options.AllowMinificationInDevelopmentEnvironment = true;
            options.AllowCompressionInDevelopmentEnvironment = true;
        })
        .AddHtmlMinification(
            options =>
            {
                options.MinificationSettings.RemoveRedundantAttributes = true;
                options.MinificationSettings.RemoveHttpProtocolFromAttributes = true;
                options.MinificationSettings.RemoveHttpsProtocolFromAttributes = true;
            })
          .AddHtmlMinification(
            options =>
            {
                options.MinificationSettings.RemoveRedundantAttributes = true;
                options.MinificationSettings.RemoveHttpProtocolFromAttributes = true;
                options.MinificationSettings.RemoveHttpsProtocolFromAttributes = true;
            })
        .AddHttpCompression();
            
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory, SeedDataHelper seed)
        {
            loggerFactory.AddConsole(Configuration.GetSection("Logging"));
            //loggerFactory.AddNLog();
            //loggerFactory.AddDebug();
            
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseBrowserLink();
                
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                //app.UseStatusCodePagesWithReExecute("/errors/{0}");

            }
            //app.AddNLogWeb();
            //env.ConfigureNLog("nlog.config");

            app.UseStaticFiles();
            

            //app.UseCors(builder => {
            //    builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader();
            //});

            app.UseWebMarkupMin();
                        
            app.UseStatusCodePages();

            app.UseCookieAuthentication();

            app.UseIdentity()
               .UseFacebookAuthentication(new FacebookOptions
               {
                   AppId = "513909428944612",
                   AppSecret = "ff39f291e39d36224dcb6e8687fbbf0c"
               })
                .UseGoogleAuthentication(new GoogleOptions
                {
                    ClientId = "1007746957521-ei30jkh72jq90fec7m3re91dpeaobgl4.apps.googleusercontent.com",
                    ClientSecret = "MEKtgoPZGPYxu9aHqkIeqmqj-"
                })
                .UseTwitterAuthentication(new TwitterOptions
                {
                    ConsumerKey = "tl0zTPXYqQRV969qVbXyCQsb8",
                    ConsumerSecret = "fF4cdlcMxeDrvZJFLRZAj7SDkQt7NYBetewCzbJzRxUUbPCMmO"
                });

            seed.Initialize();


            app.UseMvc(routes =>
            {
                routes.MapRoute(
                   name: "areaRoute",
                   template: "{area:exists}/{controller}/{action}/{id?}",
                   defaults: new { controller = "Home", action = "Index" });
                    
                routes.MapRoute(
                    name: "default",
                    template: "{controller}/{action}/{id?}",
                    defaults: new { controller = "Home", action = "Index" });

                routes.MapRoute(
                   name: "admin",
                   template: "admin/{action}/{id?}",
                   defaults: new { area = "admin", controller = "Home", action = "Index" });
                
            });
        }


    }

    

}