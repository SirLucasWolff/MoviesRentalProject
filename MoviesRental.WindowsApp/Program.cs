using MoviesRental.Domain.EmployeeModule;
using MoviesRental.Infra.ORM;
using MoviesRental.WindowsApp.Shared;
using System.Net;

namespace MoviesRental.WindowsApp
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            EmailConnection emailConnection = new EmailConnection();

            if (emailConnection.isConnected())
                emailConnection.SendEmailCached();

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());
        }
    }
}