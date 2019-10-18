using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;


namespace UNFHackAThon
{
    public class Program
    {
        // Where the application of this program kicks off
        public static void Main(string[] args)
        {
            //Builds the webhost. Calling the run method. Listen to the upcoming http request
            CreateWebHostBuilder(args).Build().Run();


        }

        // Returns an object that bulilds Web Host builder method
        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
              // Extention method
            .UseStartup<Startup>();


    }
}
