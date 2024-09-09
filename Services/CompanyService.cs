using PdfSharp.Drawing;
using static PDFGenerator.Constants.FontConstant;
using static PDFGenerator.Helpers.TextHelper;
using PDFGenerator.Domains;

namespace PDFGenerator.Services
{
    public class CompanyService
    {


        public static void AddCompanyDetails(XGraphics gfx, Root data)
        {
            var companyDetails = $"{data.General.ClientName}, {data.General.ClientStreet}, {data.General.ClientCity}";
            gfx.DrawString(companyDetails, DefaultFontBold, XBrushes.Black, 50, 135);
        }

        public static void AddCompanyDetailsUpperRight(XGraphics gfx, double xPosition, Root data)
        {

            gfx.DrawString(data.General.ClientName, DefaultFontBold, XBrushes.Black, xPosition, 135);
            gfx.DrawString(data.General.ClientStreet, DefaultFont, XBrushes.Black, xPosition, 145);
            gfx.DrawString(data.General.ClientCity, DefaultFont, XBrushes.Black, xPosition, 155);


        }

        public static void AddCompanyContacts(XGraphics gfx, double xPosition, Root data)
        {
            DrawTextLines(gfx, [
            data.General.ClientTel,
            data.General.ClientMail,
            data.General.ClientUrl
               ], xPosition, 180, DefaultFont);
        }

    }

}