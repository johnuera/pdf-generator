using PdfSharp.Drawing;
using static PDFGenerator.Constants.PdfConstant;
using static PDFGenerator.Constants.FontConstant;
using static PDFGenerator.Helpers.TextHelper;

namespace PDFGenerator.Services
{
    public class CustomerService{
    
    public static void AddCustomerDetails(XGraphics gfx)
    {
        DrawTextLines(gfx, CustomerDetails, 50,  150, DefaultFont);
    }

     
    }

}