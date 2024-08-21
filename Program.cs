using System;
using System.Linq;
using PdfSharp.Pdf;
using PdfSharp.Drawing;
using static PDFGenerator.Services.LogoService;
using static PDFGenerator.Services.CustomerService;
using static PDFGenerator.Services.CompanyService;
using static PDFGenerator.Services.OrderService;

using static PDFGenerator.Constants.FontConstant;

class Program
{
    static void Main()
    {
        // Create a PDF document and a page
        using (var document = new PdfDocument())
        {
            document.Info.Title = "Created with PDFsharp";
            var page = document.AddPage();
            page.Size = PdfSharp.PageSize.A4;

            // Create graphics object
            using (var gfx = XGraphics.FromPdfPage(page))
            {
                // Add content
                double imageXPosition = AddLogo(gfx);
                AddCompanyDetails(gfx);
                AddCustomerDetails(gfx);
                AddCompanyDetailsUpperRight(gfx, imageXPosition);
                AddCompanyContacts(gfx, imageXPosition);
                AddOrderDetails(gfx, imageXPosition);
                AddOrderHeader(gfx);
                AddOrderItems(gfx);
            }

            // Save the document
            document.Save("HelloWorld.pdf");
            Console.WriteLine("PDF file saved to: HelloWorld.pdf");
        }
    }






}
