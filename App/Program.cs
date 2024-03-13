using Honest.Timesheet.DbMigrator;
using Honest.Timesheet.Domain.Interfaces;
using Honest.Timesheet.Persistence;
using Honest.Timesheet.Persistence.Repositories;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace App
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.SetHighDpiMode(HighDpiMode.SystemAware);

            var host = CreateHostBuilder().Build();

            DbMigrator.Migrate("Data Source=.\\Data.db");
            Application.Run(host.Services.GetRequiredService<Main>());
        }

        private static IHostBuilder CreateHostBuilder()
        {
            return Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) =>
                {
                    services.AddDbContext<AppDbContext>();
                    services.RegisterForms();
                    services.RegisterRepositories();
                });
        }

        private static void RegisterForms(this IServiceCollection services)
        {
            services.AddTransient<Main>();
        }

        private static void RegisterRepositories(this IServiceCollection services)
        {
            services.AddTransient<IProjectRepository, ProjectRepository>();
        }
    }
}