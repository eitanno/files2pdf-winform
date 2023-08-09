using FilesToPDF.Api.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Serilog.Extensions.Logging.File;

namespace Files2PDFWFA
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
           
            var configuration = new ConfigurationBuilder()
            .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
            .AddJsonFile("appsettings.json")
            .Build();

            var host = Host.CreateDefaultBuilder()
             .ConfigureServices((context, services) =>
             {
                 services.AddLogging(builder =>
                 {
                     //builder.AddConfiguration(configuration.GetSection("Logging:File:Path"));
                     builder.AddConsole();
                     builder.AddFile(configuration["Logging:File:Path"]);
                 });

                 services.AddSingleton<ExcelConversionService>();
                 services.AddSingleton<PDFConversionService>();
                 services.AddSingleton<PicConversionService>();
                 services.AddSingleton<PowerPointConversionService>();
                 services.AddSingleton<TIFFConversionService>();
                 services.AddSingleton<WordConversionService>();
                 services.AddSingleton<FilesToPDFService>();

                 services.AddSingleton<Form1>(); // Add your main form here
             })
             .Build();

            var form = host.Services.GetRequiredService<Form1>(); // Get the main form
            Application.Run(form);
        }
    }
}