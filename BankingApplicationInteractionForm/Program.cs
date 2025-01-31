using BankingApplication;
using BankingApplication.Interfaces;
using BankingApplication.LogicClasses;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;

namespace BankingApplicationInteractionForm
{
    internal static class Program
    {

        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            var serviceCollection = new ServiceCollection();
            ConfigureServices(serviceCollection);

            var serviceProvider = serviceCollection.BuildServiceProvider();
            var loginForm = serviceProvider.GetRequiredService<LoginForm>();
            Application.Run(loginForm);
        }
        private static void ConfigureServices(IServiceCollection services)
        {

            services.AddDbContext<BankingApplicationDbContext>(options =>
            options.UseSqlServer(@"Data Source=.\HYDAELYN;Initial Catalog=BankingApplicationDb;Integrated Security=True;Encrypt=False;"));

            //makes the dependencies available to the below forms on request
            services.AddSingleton<IBankUserService, BankUserService>();
            services.AddSingleton<IBankAccountService, BankAccountService>();
            services.AddSingleton<ITransactionService, TransactionService>();
            services.AddSingleton<IPasswordHashingService, PasswordHashingService>();
            services.AddSingleton<LoginForm>();
            services.AddSingleton<CreateUserForm>();

        }


    }
}