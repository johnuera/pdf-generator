using PdfSharp.Drawing;
using static PDFGenerator.Constants.PdfConstant;
using static PDFGenerator.Constants.FontConstant;
using static PDFGenerator.Helpers.TextHelper;
using PDFGenerator.Domains;

namespace PDFGenerator.Services
{
    public class CompanyService{
    
   
   public static void AddCompanyDetails(XGraphics gfx, Root data)
    {
        var companyDetails = $"{data.General.ClientName}, {data.General.ClientStreet}, {data.General.ClientCity}";
        gfx.DrawString(companyDetails, DefaultFontBold, XBrushes.Black, 50, 150);
    }

    public static void AddCompanyDetailsUpperRight(XGraphics gfx, double xPosition, Root data)
{
    DrawTextLines(gfx,
    [
        data.General.ClientName,
        data.General.ClientStreet,
        data.General.ClientCity
    ], xPosition,  150, DefaultFontBold);
}

    public static void AddCompanyContacts(XGraphics gfx, double xPosition, Root data)
    {
         DrawTextLines(gfx, [
            data.General.ClientTel,
            data.General.ClientMail,
            data.General.ClientUrl
            ], xPosition,   200, DefaultFont);
    }
     
    }

}