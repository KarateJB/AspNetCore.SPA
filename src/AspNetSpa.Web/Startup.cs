using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.SpaServices.Webpack;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using JSNLog;
using NLog.Extensions.Logging;
using NLog.Web;
using AspNetSpa.Service;
using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
namespace AspNetSpa_Web
{
    public class Startup
    {
        public Startup(IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true)
                .AddEnvironmentVariables();
            Configuration = builder.Build();
        }

        public IConfigurationRoot Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            // Add framework services.
            services.AddMvc((options) =>
                options.CacheProfiles.Add("default", new CacheProfile()
                {
                    Duration = 60,
                    Location = ResponseCacheLocation.Client
                })
            );
            services.AddResponseCaching();
            services.AddMemoryCache();

            // services.AddTransient<IGuidServiceTransient, GuidService>();
            // services.AddScoped<IGuidServiceScoped, GuidService>();
            // services.AddSingleton<IGuidServiceSingleton, GuidService>();
            // services.AddSingleton<IGuidServiceSingletonInstance>(new GuidService(Guid.Empty));

            services.AddTransient<IGuidServiceTransient>(provider => new GuidService(title: "Transient"));
            services.AddScoped<IGuidServiceScoped>(provider => new GuidService(title: "Scoped"));
            services.AddSingleton<IGuidServiceSingleton>(provider => new GuidService(title: "Singleton"));
            services.AddSingleton<IGuidServiceSingletonInstance>(new GuidService("Instance", Guid.Empty));


            //Register custom routing
            services.AddRouting(options =>
                options.ConstraintMap.Add("Custom", typeof(CustomRouteConstraint)));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            app.UseExceptionHandler("/Home/Error");

            // loggerFactory.AddConsole(Configuration.GetSection("Logging"));
            // loggerFactory.AddDebug();

            #region NLog
            //add NLog to ASP.NET Core
            loggerFactory.WithFilter(new FilterLoggerSettings{
                    { "Microsoft", LogLevel.Warning },
                    { "System", LogLevel.None },
                    { "Default", LogLevel.Debug }
            }).AddNLog();

            env.ConfigureNLog("NLog.config");

            #endregion

            #region JSNLog
            // Configure JSNLog
            // See jsnlog.com/Documentation/Configuration
            var jsnlogConfiguration = new JsnlogConfiguration();
            app.UseJSNLog(new LoggingAdapter(loggerFactory), jsnlogConfiguration);
            #endregion


            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseWebpackDevMiddleware(new WebpackDevMiddlewareOptions
                {
                    HotModuleReplacement = true
                });
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseStaticFiles();

            app.UseMvc(routes =>
            {


                //1. With constraint
                // routes.MapRoute(
                //     name: "default",
                //     template: "{controller=Home}/{action=Index}/{id:min(10):max(15)}");


                //2. Catch-all
                // routes.MapRoute(
                //    name: "help",
                //    template: "HelpMe/{*question}",
                //    defaults: new { controller = "Home", action = "Help" });

                //2. Custom constraint
                // routes.MapRoute(
                //    name: "default",
                //    template: "{controller=Home}/{action=Index}/{id:Custom}");

                //Default
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");


                routes.MapSpaFallbackRoute(
                    name: "spa-fallback",
                    defaults: new { controller = "Home", action = "Index" });
            });
        }
    }
}