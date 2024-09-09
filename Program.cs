using PdfSharp.Pdf;
using static PDFGenerator.Services.InvoiceService;
using PDFGenerator.Domains;

class Program
{
    static void Main()
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
            int totalOrders = GenerateInvoice(document,data);

            //create PDF File
            DateTimeOffset now = DateTimeOffset.UtcNow;
            var name = $"{data.General.ClientName}-pdf-with-{totalOrders}-items.pdf";

            // Save the document
            document.Save(name);
            Console.WriteLine($"PDF file saved to: {name}");
        }


    }
   
}




