using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace AirplaneCrud.API
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args)
        {
            return WebHost.CreateDefaultBuilder(args)
                        .UseUrls("https://*:5100")
                        .UseStartup<Startup>();
        }
    }
}