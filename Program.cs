﻿using System.IO;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;

namespace helloskylinerapp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // read configuration values from command line and environment
            // variables
            var config = new ConfigurationBuilder()
                .AddEnvironmentVariables()
                .Build();

            // use Kestrel server with cwd content root
            var host = new WebHostBuilder()
                .UseConfiguration(config)
                .UseKestrel()
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseStartup<Startup>()
                .UseUrls("http://0.0.0.0:8080")
                .Build();
            host.Run();
        }
    }
}
