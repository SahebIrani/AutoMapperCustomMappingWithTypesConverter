using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

using System.Threading.Tasks;

namespace Simple
{
    public class Program
    {
        public static async Task Main(string[] args) => await CreateWebHostBuilder(args).Build().RunAsync().ConfigureAwait(false);

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args).UseStartup<Startup>();
    }
}
