using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace helloskylinerapp
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            // enable MVC framework
            services.AddMvc();
        }

        public void Configure(IApplicationBuilder app,  IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            // enable debug logging when not in production
            if (env.IsProduction())
            {
                loggerFactory.AddConsole(LogLevel.Information);
            } else {
                loggerFactory.AddConsole(LogLevel.Debug);
            }

            // enable exception pages in development
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            // serve static files from wwwroot/*
            app.UseStaticFiles();

            // use MVC framework
            app.UseMvc();
        }
    }
}
