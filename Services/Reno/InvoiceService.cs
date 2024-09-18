using PdfSharp.Drawing;
using static PDFGenerator.Constants.PdfConstant;
using PDFGenerator.Domains;
using static PDFGenerator.Services.Reno.LogoService;
using static PDFGenerator.Services.Reno.CustomerService;
using static PDFGenerator.Services.Reno.CompanyService;
using static PDFGenerator.Services.Reno.OrderService;
using static PDFGenerator.Services.Reno.FooterService;
using static PDFGenerator.Services.Reno.MessageService;
using static PDFGenerator.Services.Reno.ComputeService;
using PdfSharp.Pdf;
namespace PDFGenerator.Services.Reno
{
    public class InvoiceService
    {

        public static void Run()
        {
            // Get client data from JSON located at data folder
            string filePath = "data/reno-de.json";
            Root data = JsonReader.ReadJsonFromFile(filePath); //serialize json to match the Root Object

            //Accessing the property
            Console.WriteLine($"Client Name: {data.General.ClientName}");

            //Create a PDF document and a page
            using (var document = new PdfDocument())
            {
                //add document title
                document.Info.Title = $"Invoice for {data.General.ClientName}  ";

                //Create Invoice Page with return value of total orders
                int totalOrders = GenerateInvoice(document, data);

                //create PDF File
                DateTimeOffset now = DateTimeOffset.UtcNow;
                var name = $"{data.General.ClientName}-pdf-with-{totalOrders}-items.pdf";

                // Save the document
                document.Save(name);
                Console.WriteLine($"PDF file saved to: {name}");
            }

        }
        public static int GenerateInvoice(PdfDocument document, Root data)
        {

            int totalOrders = OrderItems.GetLength(0);
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
                    AddFooter(gfx, data);
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
                                AddExtraPageForMessage(document, data);
                            }
                        }

                        AddFooter(gfx, data);
                    }
                }



            }
            return totalOrders;
        }

        static void AddExtraPageForMessage(PdfDocument document, Root data)
        {
            var messagePage = document.AddPage();
            messagePage.Size = PdfSharp.PageSize.A4;

            using (var messageGFX = XGraphics.FromPdfPage(messagePage))
            {
                double newLogoXPosition = AddHeader(messageGFX, data, true);
                AddMessage(messageGFX, data, 230);
                AddFooter(messageGFX, data);
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
                AddInvoiceHeadline(gfx, data);
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
        static void AddFooter(XGraphics gfx, Root data)
        {
            AddLeftFooter(gfx, data);
            AddRightFooter(gfx, data);
        }

    }

}