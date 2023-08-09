using Microsoft.Extensions.Logging;
using Microsoft.Office.Interop.Excel;
using Application = Microsoft.Office.Interop.Excel.Application;
using Range = Microsoft.Office.Interop.Excel.Range;

namespace FilesToPDF.Api.Services
{
    public class ExcelConversionService
    {


        private readonly ILogger<ExcelConversionService> _logger;

        public ExcelConversionService(ILogger<ExcelConversionService> logger)
        {
            _logger = logger;
        }
        public void ConvertExcelToPDF(string inputFile, string outputFile)
        {
            Application excel = new Application();
            Workbook workbook = null;
            try
            {
                workbook = excel.Workbooks.Open(inputFile);
                //Worksheet worksheet = (Worksheet)workbook.Sheets[1];
                //// Find the last used row in the worksheet
                //int lastRow = worksheet.Cells.Find("*", System.Reflection.Missing.Value, System.Reflection.Missing.Value,
                //    System.Reflection.Missing.Value, XlSearchOrder.xlByRows, XlSearchDirection.xlPrevious,
                //    false, System.Reflection.Missing.Value, System.Reflection.Missing.Value).Row;

                //// Find the last used column in the worksheet
                //int lastColumn = worksheet.Cells.Find("*", System.Reflection.Missing.Value, System.Reflection.Missing.Value,
                //    System.Reflection.Missing.Value, XlSearchOrder.xlByColumns, XlSearchDirection.xlPrevious,
                //    false, System.Reflection.Missing.Value, System.Reflection.Missing.Value).Column;
                //Range usedRange = worksheet.Range[worksheet.Cells[1, 1], worksheet.Cells[lastRow, lastColumn]];
                workbook.ExportAsFixedFormat(XlFixedFormatType.xlTypePDF, outputFile);
                
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Error processing file: {inputFile}.");
            }
            finally
            {
                if (workbook != null)
                    workbook.Close(false);
                if (excel != null)
                    excel.Quit();
            }
        }
    }
}