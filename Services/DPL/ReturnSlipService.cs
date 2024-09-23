using PdfSharp.Drawing;
using static PDFGenerator.Constants.PdfConstant;
using PDFGenerator.Domains;

using PdfSharp.Pdf;
namespace PDFGenerator.Services.DPL
{
    public class ReturnSlipService
    {

        public static void Run()
        {
            // Get client data from JSON located at data folder
            string filePath = "data/dpl-de.json";
            Root data = JsonReader.ReadJsonFromFile(filePath); //serialize json to match the Root Object

            //Accessing the property
            Console.WriteLine($"Client Name: {data.General.ClientCode}");

            //Create a PDF document and a page
            using (var document = new PdfDocument())
            {
                //add document title
                document.Info.Title = $"Return Slip for {data.General.ClientName}  ";

                //Create Invoice Page with return value of total orders
                int totalItems = GenerateMultipleReturnSlip(document, data);

                //create PDF File
                DateTimeOffset now = DateTimeOffset.UtcNow;
                var name = $"{data.General.ClientCode}-pdf-with-{totalItems}-items.pdf";

                // Save the document
                document.Save(name);
                Console.WriteLine($"PDF file saved to: {name}");
            }

        }


        private static int GenerateMultipleReturnSlip(PdfDocument document, Root data)
        {
            int totalOrders = ReturnItems.GetLength(0);
            if (totalOrders <= 10)
            {
                var page = document.AddPage();
                page.Size = PdfSharp.PageSize.A4;
                using (var gfx = XGraphics.FromPdfPage(page))
                {
                    LogoService.AddLogo(gfx, data);
                    HeaderService.AddHeader(gfx, data);
                    HeaderService.AddMessage(gfx, data);
                    FooterService.AddCenterFooter(gfx, data);
                    CustomerService.AddCustomerAddress(gfx, data);
                    CustomerService.AddOrderDetails(gfx, data);
                    CustomerService.AddBarcode(gfx, data);

                    HeaderService.AddReturnTitle(gfx, data);
                    var returnItemYPosition = ReturnService.AddReturnItems(gfx, data, 0, totalOrders, 315);
                    ReturnService.AddReturnReason(gfx, data, returnItemYPosition);
                    MessageService.AddReturnMessage(gfx, returnItemYPosition, data);
                }
            }
            else
            {
                int ordersPerPage = 10;
                int numberOfPages = (int)Math.Ceiling((double)totalOrders / ordersPerPage);

                for (int i = 0; i < numberOfPages; i++)
                {
                    var page = document.AddPage();
                    page.Size = PdfSharp.PageSize.A4;

                    using (var gfx = XGraphics.FromPdfPage(page))
                    {
                        int startIndex = i * ordersPerPage;
                        int maxItems = Math.Min(ordersPerPage, totalOrders - startIndex);
                        // Add header and logo
                        LogoService.AddLogo(gfx, data);
                        HeaderService.AddHeader(gfx, data);
                        HeaderService.AddMessage(gfx, data);
                        FooterService.AddCenterFooter(gfx, data);
                        CustomerService.AddCustomerAddress(gfx, data);
                        CustomerService.AddOrderDetails(gfx, data);
                        CustomerService.AddBarcode(gfx, data);

                        HeaderService.AddReturnTitle(gfx, data);
                        var returnItemYPosition = ReturnService.AddReturnItems(gfx, data, startIndex, maxItems, 315);
                        ReturnService.AddReturnReason(gfx, data, returnItemYPosition);
                        MessageService.AddReturnMessage(gfx, returnItemYPosition, data);
                    }
                }



            }
            return totalOrders;
        }


        private static void GenerateReturnSlip(PdfDocument document, Root data)
        {
            var page = document.AddPage();
            page.Size = PdfSharp.PageSize.A4;
            using (var gfx = XGraphics.FromPdfPage(page))
            {
                LogoService.AddLogo(gfx, data);
                HeaderService.AddHeader(gfx, data);
                HeaderService.AddMessage(gfx, data);
                FooterService.AddCenterFooter(gfx, data);
                CustomerService.AddCustomerAddress(gfx, data);
                CustomerService.AddOrderDetails(gfx, data);
                HeaderService.AddReturnTitle(gfx, data);
                var returnItemYPosition = ReturnService.AddReturnItems(gfx, data, 0, 8, 315);
                ReturnService.AddReturnReason(gfx, data, returnItemYPosition);
                MessageService.AddReturnMessage(gfx, returnItemYPosition, data);
            }
        }

    }
}

