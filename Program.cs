using System;
using System.Linq;
using PdfSharp.Pdf;
using PdfSharp.Drawing;
using static PDFGenerator.Services.LogoService;
using static PDFGenerator.Services.CustomerService;
using static PDFGenerator.Services.CompanyService;
using static PDFGenerator.Services.OrderService;
using PdfSharpCore.Fonts;

using static PDFGenerator.Constants.FontConstant;
using PDFGenerator.Domains;
using PdfSharpCore.Fonts;
using PDFGenerator.Helpers;

class Program
{
    static void Main()
    {
        
        // This should be part of your initialization code
        GlobalFontSettings.FontResolver = CalibriFontResolver.Instance;
        string filePath = "data/de.json";
         Root data = JsonReader.ReadJsonFromFile(filePath);

        // Example: Accessing some properties
        Console.WriteLine($"Client Name: {data.General.ClientName}");
        //Console.WriteLine($"Invoice Date: {data.OrderText.Date}");


        //Create a PDF document and a page
        using (var document = new PdfDocument())
        {
            document.Info.Title = "Created with PDFsharp";
            var page = document.AddPage();
            page.Size = PdfSharp.PageSize.A4;

            // Create graphics object
            using (var gfx = XGraphics.FromPdfPage(page))
            {
                // Add content
                double imageXPosition = AddLogo(gfx,data);
                AddCompanyDetails(gfx,data);
                AddCustomerDetails(gfx);
                AddCompanyDetailsUpperRight(gfx, imageXPosition,data);
                AddCompanyContacts(gfx, imageXPosition,data);
                AddOrderDetails(gfx, imageXPosition);
                AddOrderHeader(gfx,data);
                AddOrderItems(gfx);
            }

            // Save the document
            document.Save("HelloWorld.pdf");
            Console.WriteLine("PDF file saved to: HelloWorld.pdf");
        }
    }






}
