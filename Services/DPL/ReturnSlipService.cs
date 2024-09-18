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
                GenerateReturnSlip(document, data);

                //create PDF File
                DateTimeOffset now = DateTimeOffset.UtcNow;
                var name = $"{data.General.ClientCode}-pdf-with-items.pdf";

                // Save the document
                document.Save(name);
                Console.WriteLine($"PDF file saved to: {name}");
            }

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

            }
        }

    }
}

