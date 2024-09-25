using PdfSharp.Drawing;
using static PDFGenerator.Constants.FontConstant;
using static PDFGenerator.Helpers.TextHelper;
using PDFGenerator.Domains;

namespace PDFGenerator.Services.DPL
{
    public class CompanyService
    {


        public static void AddCompanyDetails(XGraphics gfx, Root data)
        {
            var companyDetails = $"{data.General.ClientName} | {data.General.ClientStreet} | {data.General.ClientCity}";
            gfx.DrawString(companyDetails, DefaultFontUnderlined, XBrushes.Black, 55.5, 140);
        }

    }

}