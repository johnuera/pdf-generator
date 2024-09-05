using PdfSharp.Pdf;
using static PDFGenerator.Services.InvoiceService;
using PDFGenerator.Domains;

class Program
{
    static void Main()
    {

        // Get client data from JSON
        string filePath = "data/reno-de.json";
        Root data = JsonReader.ReadJsonFromFile(filePath);

        //Accessing some properties
        Console.WriteLine($"Client Name: {data.General.ClientName}");
 
        //Create a PDF document and a page
        using (var document = new PdfDocument())
        {
            document.Info.Title = "Created with PDFsharp";
            int totalOrders = GenerateInvoice(document,data);
            DateTimeOffset now = DateTimeOffset.UtcNow;
            var name = $"reno-pdf-with-{totalOrders}-items.pdf";

            // Save the document
            document.Save(name);
            Console.WriteLine($"PDF file saved to: {name}");
        }


    }
   
}




