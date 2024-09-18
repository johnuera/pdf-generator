using PdfSharp.Pdf;
using static PDFGenerator.Services.Reno.InvoiceService;
using PDFGenerator.Domains;
using PDFGenerator.Services.Reno;
using PDFGenerator.Services.DPL;

class Program
{
    static void Main()
    {

      ReturnSlipService.Run();

    }
   
}




