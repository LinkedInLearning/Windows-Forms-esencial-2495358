using Microsoft.Extensions.Configuration;
using System.Configuration;

namespace BaseDeDatos;

internal static class Program
{
    public static IConfiguration Configuration;
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        ApplicationConfiguration.Initialize();

        var builder = new ConfigurationBuilder()
            .AddJsonFile("appsettings.json",
                    optional: true,
                    reloadOnChange: true);
        Configuration = builder.Build();

        Application.Run(new MainForm());
    }
}