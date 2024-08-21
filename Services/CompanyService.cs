using PdfSharp.Drawing;
using static PDFGenerator.Constants.PdfConstant;
using static PDFGenerator.Constants.FontConstant;
using static PDFGenerator.Helpers.TextHelper;

namespace PDFGenerator.Services
{
    public class CompanyService{
    
   
    public static void AddCompanyDetails(XGraphics gfx)
    {
        gfx.DrawString(string.Join(", ", CompanyDetails), DefaultFontBold, XBrushes.Black, 50, 150);
    }

    public static void AddCompanyDetailsUpperRight(XGraphics gfx, double xPosition)
    {
        double yPosition = 150;
        DrawTextLines(gfx, CompanyDetails, xPosition, ref yPosition, DefaultFontBold);
    }

    public static void AddCompanyContacts(XGraphics gfx, double xPosition)
    {
        double yPosition = 200;
        DrawTextLines(gfx, CompanyContacts, xPosition, ref yPosition, DefaultFont);
    }
     
    }

}