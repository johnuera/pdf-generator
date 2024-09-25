using PdfSharp.Drawing;
using PDFGenerator.Domains;
using PdfSharp.Pdf;
namespace PDFGenerator.Services.DPL
{
    public class InvoiceService
    {

        public static void Run()
        {
            // Get client data from JSON located at data folder
            string filePath = "data/dpl-de.json";
            Root data = JsonReader.ReadJsonFromFile(filePath); //serialize json to match the Root Object

            //Accessing the property
            Console.WriteLine($"Client Name: {data.General.ClientName}");

            //Create a PDF document and a page
            using (var document = new PdfDocument())
            {
                //add document title
                document.Info.Title = $"Invoice for {data.General.ClientName}  ";

                //Create Invoice Page with return value of total orders
                GenerateInvoice(document, data);

                //create PDF File
                DateTimeOffset now = DateTimeOffset.UtcNow;
                var name = $"{data.General.ClientName}-pdf-with-items.pdf";

                // Save the document
                document.Save(name);
                Console.WriteLine($"PDF file saved to: {name}");
            }

        }
        private static void GenerateInvoice(PdfDocument document, Root data)
        {
            var page = document.AddPage();
            page.Size = PdfSharp.PageSize.A4;
            using (var gfx = XGraphics.FromPdfPage(page))
            {
                LogoService.AddLogo(gfx, data);
                HeaderService.AddHeader(gfx, data);
                //HeaderService.AddMessage(gfx, data);
                CompanyService.AddCompanyDetails(gfx,data);
                FooterService.AddCenterFooter(gfx, data);
                CustomerService.AddCustomerAddress(gfx, data,160);
                CustomerService.AddInvoiceAddress(gfx, data,160);
                CustomerService.AddOrderDetails(gfx, data,300,160);

                CustomerService.AddBarcode(gfx, data);

                // HeaderService.AddReturnTitle(gfx, data);
                // var returnItemYPosition = ReturnService.AddReturnItems(gfx, data, 0, 8, 315);
                // ReturnService.AddReturnReason(gfx, data, returnItemYPosition);
                // MessageService.AddReturnMessage(gfx, returnItemYPosition, data);
            }
        }
    }
}