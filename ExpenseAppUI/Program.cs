using Microsoft.Extensions.DependencyInjection;
using Expense.Infrastructure;
using Expense.Application;

namespace ExpenseAppUI
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        /// 
        public static bool isValid = false;

        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            var services = new ServiceCollection();

            ConfigureServices(services);

            services.AddScoped<Form1>();
                     
            using (ServiceProvider serviceProvider = services.BuildServiceProvider())
            { 
                var form1 = serviceProvider.GetRequiredService<Form1>();
                Application.Run(form1);
            } 
       
            if (isValid == true)
            { 
                Application.Run(new MainForm(Form1.Id));
            }
        }

        private static void ConfigureServices(ServiceCollection services)
        {
            services.AddApplicationServices();
            services.AddInfrastructureServices();
        }
    }
}