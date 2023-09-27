using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Models.Entities;
using Models.FFIFND;

namespace Models
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("appsettings.json")
                .Build();

            var serviceProvider = new ServiceCollection()
                .AddSingleton(configuration)
                .AddTransient<INPRoutine, NPRoutine>()
                .AddTransient<ODDANP>()
                .BuildServiceProvider();

            var oddanp = serviceProvider.GetRequiredService<ODDANP>();
            string err = string.Empty;
            oddanp.Routine.GetFromDatabase<Category>(ref err, "select * from categories where is_active=1"); ;
        }
    }
}