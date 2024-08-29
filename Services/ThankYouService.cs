
using static PDFGenerator.Helpers.TextHelper;
using static PDFGenerator.Helpers.TableHelper;
using PDFGenerator.Domains;
using PdfSharp.Drawing;
using static PDFGenerator.Constants.PdfConstant;
using static PDFGenerator.Constants.FontConstant;

namespace PDFGenerator.Services
{
    public class ThankYouService{
 public static void AddThankYouMessage(XGraphics gfx,double orderItemsYPosition,Root data)
    {
        gfx.DrawString(data.InvoiceDetails.ThankYou, DefaultFontHeader, XBrushes.Black, 50, orderItemsYPosition+100);
    }
    }
}