using PDFGenerator.Domains;
using PDFGenerator.Helpers;
using PdfSharp.Drawing;
using static PDFGenerator.Constants.PdfConstant;
using static PDFGenerator.Constants.FontConstant;
using System.Drawing;
namespace PDFGenerator.Services.DPL
{
    public class HeaderService
    {

        public static void AddHeader(XGraphics gfx, Root data)
        {

            double valueX = gfx.PageSize.Width - 55.5;

            TextHelper.DrawRightAlignedText(gfx, FooterBoldFont, "", "KUNDENSERVICE", 63.2, 82, 0);
            TextHelper.DrawRightAlignedText(gfx, FooterDefaultFont, "", data.General.ClientMail, 63.2, 90, 0);
            TextHelper.DrawRightAlignedText(gfx, FooterDefaultFont, "", data.General.ClientUrl, 63.2, 98, 0);
            gfx.DrawLine(new XPen(XColor.FromKnownColor(XKnownColor.Black), .5), new XPoint(valueX, 75), new XPoint(valueX, 100));
        }



        public static void AddMessage(XGraphics gfx, Root data)
        {
            var text = data.ReturnText.ReturnHeadline;
            var textWidth = gfx.MeasureString(text, FontHeaderBold).Width;

            // Calculate the xPosition to center the text
            var xPosition = (gfx.PageSize.Width - textWidth) / 2;
            gfx.DrawString(text, FontHeaderBold, XBrushes.Black, xPosition, 155.7);

        }
        public static void AddReturnTitle(XGraphics gfx, Root data)
        {
 
            // Calculate the xPosition to center the text
         
            gfx.DrawString(data.ReturnText.ReturnTitle, MediumBoldFont, XBrushes.Black, 55.5, 296.5);

        }

    }
}