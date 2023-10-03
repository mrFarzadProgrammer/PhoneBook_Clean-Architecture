using App.DataBase;
using App.Services.AddNewContact;
using App.Services.DeleteContact;
using App.Services.GetContactDetails;
using App.Services.GetListContact;
using Microsoft.Extensions.DependencyInjection;
using Persistence.Context;
using System;
using System.Windows.Forms;
using UI.Forms;

namespace PhoneBook.EntPoint
{
    internal static class Program
    {
        public static IServiceProvider ServiceProvider { get; set; }

        static void ConfigureServices()
        {
            var services = new ServiceCollection();
            services.AddScoped<IDataBaseContext, DatabaseContext>();
            services.AddScoped<IAddNewContactService, AddNewContactService>();
            services.AddScoped<IGetListContactService, GetListContactService>();
            services.AddScoped<IDeleteContactService, DeleteContactService>();
            services.AddScoped<IGetContactDetailsService, GetContactDetailsService>();
            services.AddDbContext<DatabaseContext>();

            ServiceProvider = services.BuildServiceProvider();

        }
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ConfigureServices();
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var getList = (IGetListContactService)ServiceProvider.GetService(typeof(IGetListContactService));
            var deleteContact = (IDeleteContactService)ServiceProvider.GetService(typeof(IDeleteContactService));
            Application.Run(new frmMain(getList, deleteContact));
        }
    }
}