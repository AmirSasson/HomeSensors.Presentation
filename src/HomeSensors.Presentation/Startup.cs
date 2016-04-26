using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Hosting;
using Microsoft.AspNet.Http;
using Microsoft.Extensions.DependencyInjection;
using HomeSensors.Presentation.Services;
using HomeSensors.Presentation.Contracts;
using Microsoft.Extensions.Logging;
using Microsoft.AspNet.StaticFiles;
using Microsoft.Extensions.PlatformAbstractions;
using Microsoft.AspNet.FileProviders;
using System.IO;
using Newtonsoft.Json.Serialization;

namespace HomeSensors.Presentation
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit http://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            var mvc = services.AddMvcCore();
            mvc.AddJsonFormatters(options => options.ContractResolver = new CamelCasePropertyNamesContractResolver());

            //services.AddSingleton<ISensorsService, DocumentDBSensorService>();
            services.AddSingleton<ISensorsService, MockSensorService>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, ILoggerFactory logFac, IApplicationEnvironment appEnv, IHostingEnvironment hostEnv)
        {
            app.UseIISPlatformHandler();
            if (hostEnv.IsDevelopment())
            {
                logFac.AddConsole();
            }

            app.UseMvc();
            app.Use(async (context, next) =>
            {
                var log = logFac.CreateLogger(context.Request.Path);
                log.LogDebug($"Executing request {context.Request.Path}");
                //await context.Response.WriteAsync("Hello World!");
                await next();

                if (context.Response.StatusCode == (int)System.Net.HttpStatusCode.NotFound)//supporting SPA map to root, the SPA client platform will handle the client routing on browser
                {
                    context.Request.Path = "/index.html";
                    await next();
                }

                log.LogDebug(context.Response.StatusCode.ToString());

            });

            app.UseDefaultFiles();
            app.UseStaticFiles();
            app.UseStaticFiles(new StaticFileOptions()
            {
                FileProvider = new PhysicalFileProvider(Path.Combine(appEnv.ApplicationBasePath, "node_modules")),
                RequestPath = new PathString("/node_modules"),
            });

        }

        // Entry point for the application.
        public static void Main(string[] args) => WebApplication.Run<Startup>(args);
    }
}
