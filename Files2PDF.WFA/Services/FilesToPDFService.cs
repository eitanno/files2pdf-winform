﻿using Files2PDFWFA.Objects;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;



namespace FilesToPDF.Api.Services
{
    public class FilesToPDFService
    {
        private readonly ILogger<FilesToPDFService> _logger;
        private readonly WordConversionService _wordConversionService;
        private readonly ExcelConversionService _excelConversionService;
        private readonly PowerPointConversionService _powerPointConversionService;
        private readonly TIFFConversionService _tiffConversionService;
        private readonly PicConversionService _picConversionService;

        public FilesToPDFService(ILogger<FilesToPDFService> logger, WordConversionService wordConversionService, 
            ExcelConversionService excelConversionService,
            PowerPointConversionService powerPointConversionService, TIFFConversionService tiffConversionService,
            PicConversionService picConversionService)
        {
            _logger = logger;
            _wordConversionService = wordConversionService;
            _excelConversionService = excelConversionService;
            _powerPointConversionService = powerPointConversionService;
            _tiffConversionService = tiffConversionService;
            _picConversionService = picConversionService;
        }

        public StatusMessage ConvertFilesToPDF(List<string> uploadedFiles, string outputPath)
        {
            //var config = new ConfigurationBuilder()
            //    .SetBasePath(Directory.GetCurrentDirectory())
            //    .AddJsonFile("appsettings.json")
            //    .Build();

            //string inputPath = "C:\\inputs"; //config["InputPath"] ?? string.Empty;
            //string outputPath = "C:\\output"; // config["OutputPath"] ?? string.Empty;
            string outputFileConfigName = "pdf"; // config["OutputFileName"] ?? string.Empty;

            if (!uploadedFiles.Any())
            {
                _logger.LogWarning("please add files");
                return new StatusMessage(false, "נא להוסיף קבצים", "");
            }

            List<string> pdfFileNames = new List<string>();

            foreach (string file in uploadedFiles)
            {
                string fileType = Path.GetExtension(file);
                string fileName = Path.GetFileNameWithoutExtension(file);
                string outputFileName = outputPath + "\\" + fileName + ".pdf";

                if (fileName.Contains("~"))
                    continue;
                _logger.LogInformation($"fileName: {fileName}, file type: {fileType} will be converted");
                switch (fileType)
                {
                    case ".docx":
                    case ".doc":
                        _wordConversionService.ConvertWordToPDF(file, outputFileName);
                        pdfFileNames.Add(outputFileName);
                        break;
                    case ".xls":
                    case ".xlsx":
                        _excelConversionService.ConvertExcelToPDF(file, outputFileName);
                        pdfFileNames.Add(outputFileName);
                        break;
                    case ".pptx":
                    case ".ppt":
                        _powerPointConversionService.ConvertPowerPointToPDF(file, outputFileName);
                        pdfFileNames.Add(outputFileName);
                        break;
                    case ".pdf":
                        outputFileName = file;
                        pdfFileNames.Add(outputFileName);
                        break;
                    case ".tif":
                    case ".tiff":
                        _tiffConversionService.ConvertPicToPDF(file, outputFileName);
                        pdfFileNames.Add(outputFileName);
                        break;
                    case ".jpeg":
                    case ".jpg":
                    case ".png":
                        _picConversionService.ConvertPicToPDF(file, outputFileName);
                        pdfFileNames.Add(outputFileName);
                        break;
                    // Add more cases for other file types you want to handle
                    default:
                        _logger.LogWarning($"Unsupported file type: {fileType}");
                        break;
                }
            }
            string outputFile = outputPath + "\\" + getFileName(outputFileConfigName) + ".pdf";
            PDFConversionService pdfConversionService = new PDFConversionService();
            pdfConversionService.CombinePDFs(pdfFileNames.ToArray(), outputFile);
            _logger.LogInformation($"File processed successfully : {outputFile}");
            return new StatusMessage(true, outputFile + " : " + "הקובץ נוצר בהצלחה", outputFile);
        }

        private string getFileName(string outputFileConfigName)
        {
            // Get the current date and time
            DateTime currentDate = DateTime.Now;

            // Format the date as a string
            string formattedDate = currentDate.ToString("yyyyMMdd_HHmmss");

            // Append the formatted date to the original file name
            string newFileName = $"{outputFileConfigName}_{formattedDate}";

            // Use the new file name for further processing or saving

            return newFileName;
        }

    }

}
