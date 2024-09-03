using PdfSharp.Pdf;
using PdfSharp.Drawing;
using static PDFGenerator.Services.LogoService;
using static PDFGenerator.Services.CustomerService;
using static PDFGenerator.Services.CompanyService;
using static PDFGenerator.Services.OrderService;
using static PDFGenerator.Constants.PdfConstant;
using static PDFGenerator.Services.FooterService;
using static PDFGenerator.Services.MessageService;
using static PDFGenerator.Services.ComputeService;

using PDFGenerator.Domains;

class Program
{
    static void Main()
    {
        int totalOrders = OrderItems.GetLength(0);

        // This should be part of your initialization code
        string filePath = "data/de.json";
        Root data = JsonReader.ReadJsonFromFile(filePath);

        // Example: Accessing some properties
        Console.WriteLine($"Client Name: {data.General.ClientName}");
        //Console.WriteLine($"Invoice Date: {data.OrderText.Date}");

        //Create a PDF document and a page
        using (var document = new PdfDocument())
        {
            document.Info.Title = "Created with PDFsharp";

            // Create graphics object 

            if (totalOrders <= 5)
            {
                var page = document.AddPage();

                page.Size = PdfSharp.PageSize.A4;
                using (var gfx = XGraphics.FromPdfPage(page))
                {
                    // Add content for the first page
                    double logoXPosition = AddHeader(gfx, data, false);
                    double orderItemsYPosition = AddOrderItems(gfx, startIndex: 0, maxItems: totalOrders);
                    AddComputation(gfx, orderItemsYPosition, logoXPosition);

                    AddMessage(gfx, data, orderItemsYPosition);
                    AddFooter(gfx);
                }
            }
            else
            {
                int ordersPerPage = 8;
                int numberOfPages = (int)Math.Ceiling((double)totalOrders / ordersPerPage);

                for (int i = 0; i < numberOfPages; i++)
                {
                    var page = document.AddPage();
                    page.Size = PdfSharp.PageSize.A4;

                    using (var gfx = XGraphics.FromPdfPage(page))
                    {
                        // Add header and logo
                        double logoXPosition = AddHeader(gfx, data, false);

                        // Determine the range of orders to display on this page
                        int startIndex = i * ordersPerPage;
                        int maxItems = Math.Min(ordersPerPage, totalOrders - startIndex);
                        Console.WriteLine($"Page: {i} Total Items: {maxItems}");

                        // Add order items
                        double orderItemsYPosition = AddOrderItems(gfx, startIndex, maxItems);

                        // Add computation and message if on the last page
                        if (i == numberOfPages - 1)
                        {
                            AddComputation(gfx, orderItemsYPosition, logoXPosition);

                            if (maxItems <= 5)
                            {
                                AddMessage(gfx, data, orderItemsYPosition);
                            }
                            else
                            {
                                // Add an extra page for the message if there are more than 5 items
                                AddExtraPageForMessage(document,data);
                            }
                        }

                        AddFooter(gfx);
                    }
                }



            }
            DateTimeOffset now = DateTimeOffset.UtcNow;
            var name = $"pdf-with-{totalOrders}-items.pdf";

            // Save the document
            document.Save(name);
            Console.WriteLine($"PDF file saved to: {name}");
        }


    }
    static void AddExtraPageForMessage(PdfDocument document, Root data)
    {
        var messagePage = document.AddPage();
        messagePage.Size = PdfSharp.PageSize.A4;

        using (var messageGFX = XGraphics.FromPdfPage(messagePage))
        {
            double newLogoXPosition = AddHeader(messageGFX, data, true);
            AddMessage(messageGFX, data, 230);
            AddFooter(messageGFX);
        }
    }
    static double AddHeader(XGraphics gfx, Root data, bool islastPageWithoutItem)
    {
        double imageXPosition = AddLogo(gfx, data);
        AddCompanyDetails(gfx, data);
        AddCustomerDetails(gfx);
        AddCompanyDetailsUpperRight(gfx, imageXPosition, data);
        AddCompanyContacts(gfx, imageXPosition, data);
        AddOrderDetails(gfx, imageXPosition);
        if (!islastPageWithoutItem)
        {
            AddOrderHeader(gfx, data);
        }
        return imageXPosition;
    }
    static void AddMessage(XGraphics gfx, Root data, double orderItemsYPosition)
    {
        AddThankYouMessage(gfx, orderItemsYPosition, data);
        AddPaymentMethod(gfx, orderItemsYPosition, data);
        AddReturnMessage(gfx, orderItemsYPosition, data);
        AddQRCode(gfx, orderItemsYPosition, data);
        AddSignature(gfx, orderItemsYPosition, data);
    }
    static void AddFooter(XGraphics gfx)
    {
        AddLeftFooter(gfx);
        AddRightFooter(gfx);
    }
}




