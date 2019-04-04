using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace AirplaneCrud
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args)
        {
            return WebHost.CreateDefaultBuilder(args)
                        .UseUrls("https://*:5200")
                        .UseStartup<Startup>();
        }
    }
}