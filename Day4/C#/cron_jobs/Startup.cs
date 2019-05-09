using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace cron_jobs
{
    public class Startup
    {
        private IConfiguration _config;

        public Startup(IConfiguration config)
        {
            _config = config;
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILogger<Startup> logger)
        {
            if (env.IsDevelopment())
            {
                DeveloperExceptionPageOptions developerExceptionPageOptions = new DeveloperExceptionPageOptions
                {
                    SourceCodeLineCount = 10
                };
                app.UseDeveloperExceptionPage(developerExceptionPageOptions);
            }
            // app.Use(async (context, next) =>
            // {
            //     logger.LogInformation("MW1: Incoming Request");
            //     await next();
            //     logger.LogInformation("MW1: Outgoing Response");
            // });
            // app.Use(async (context, next) =>
            // {
            //     logger.LogInformation("MW2: Incoming Request");
            //     await next();
            //     logger.LogInformation("MW2: Outgoing Response");
            // });

            DefaultFilesOptions defaultfileoptions = new DefaultFilesOptions();
            // Clear default file names and add foo.html as default name
            defaultfileoptions.DefaultFileNames.Clear();
            defaultfileoptions.DefaultFileNames.Add("foo.html");

            // default file name should be index.html/htm, default.html/htm
            // app.UseDefaultFiles();
            app.UseDefaultFiles(defaultfileoptions);
            // UseDefaultFiles should be before UseStaticFiles
            app.UseStaticFiles();


            // FileServerOptions fileserveroptions = new FileServerOptions();
            // // Clear default file names and add foo.html as default name
            // fileserveroptions.DefaultFilesOptions.DefaultFileNames.Clear();
            // fileserveroptions.DefaultFilesOptions.DefaultFileNames.Add("foo.html");
            // app.UseFileServer(fileserveroptions);
            // // Combination of UseDefaultFiles, UseStaticFiles and UseDirectoryBrowser

            app.Run(async (context) =>
            {
                // throw new Exception("Some error processing request");
                await context.Response.WriteAsync(_config["myval"] + env.EnvironmentName);
                logger.LogInformation("MW3: Request handled and response produced");
            });
        }
    }
}
