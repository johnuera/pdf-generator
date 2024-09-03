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
                    double imageXPosition = AddLogo(gfx, data);
                    AddCompanyDetails(gfx, data);
                    AddCustomerDetails(gfx);
                    AddCompanyDetailsUpperRight(gfx, imageXPosition, data);
                    AddCompanyContacts(gfx, imageXPosition, data);
                    AddOrderDetails(gfx, imageXPosition);
                    AddOrderHeader(gfx, data);
                    double orderItemsYPosition = AddOrderItems(gfx, startIndex: 0, maxItems: totalOrders);
                    AddMessage(gfx,data, orderItemsYPosition, imageXPosition);
                    AddFooter(gfx);


                }
            }
            else
            {
                // Define the number of orders per page
                int ordersPerPage = 8;
                int numberOfPages = (int)Math.Ceiling((double)totalOrders / ordersPerPage);

                for (int i = 0; i < numberOfPages; i++)
                {
                    var page = document.AddPage();
                    page.Size = PdfSharp.PageSize.A4;

                    using (var gfx = XGraphics.FromPdfPage(page))
                    {
                        // Add content for each page
                        double imageXPosition = AddLogo(gfx, data);
                        AddCompanyDetails(gfx, data);
                        AddCustomerDetails(gfx);
                        AddCompanyDetailsUpperRight(gfx, imageXPosition, data);
                        AddCompanyContacts(gfx, imageXPosition, data);
                        AddOrderDetails(gfx, imageXPosition);
                        AddOrderHeader(gfx, data);
                        AddFooter(gfx)

                        // Determine the range of orders to display on this page
                        int startIndex = i * ordersPerPage;
                        int maxItems = Math.Min(ordersPerPage, totalOrders - startIndex);
                        double orderItemsYPosition = AddOrderItems(gfx, startIndex: startIndex, maxItems: maxItems);

                        if (numberOfPages - 1 == i)
                        {
                            AddMessage(gfx,data, orderItemsYPosition, imageXPosition);

                        }
                    }
                }
            }

            DateTimeOffset now = DateTimeOffset.UtcNow;
            var name = $"pdf-with-{totalOrders}-items.pdf";

            // Save the document
            document.Save(name);
            Console.WriteLine($"PDF file saved to: {name}");
        }

        static void AddMessage(XGraphics gfx, Root data, double orderItemsYPosition, double imageXPosition)
        {
            AddThankYouMessage(gfx, orderItemsYPosition, data);
            AddPaymentMethod(gfx, orderItemsYPosition, data);
            AddReturnMessage(gfx, orderItemsYPosition, data);
            AddQRCode(gfx, orderItemsYPosition, data);
            AddSignature(gfx, orderItemsYPosition, data);
            AddComputation(gfx, orderItemsYPosition, imageXPosition);
        }
        static void AddFooter(XGraphics gfx)
        {
            AddLeftFooter(gfx);
            AddRightFooter(gfx);
        }
    }






}
