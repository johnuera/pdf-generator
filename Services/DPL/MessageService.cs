using PDFGenerator.Domains;
using PdfSharp.Drawing;
using static PDFGenerator.Constants.PdfConstant;
using static PDFGenerator.Constants.FontConstant;

namespace PDFGenerator.Services.DPL
{
    public class MessageService
    { 
        public static void AddReturnMessage(XGraphics gfx, double orderItemsYPosition, Root data)
        {
            gfx.DrawString(data.ReturnText.Hint1, ReturnMessageFont, XBrushes.Black, 55, orderItemsYPosition + 140); 

            gfx.DrawString(data.General.ClientSignature, ReturnMessageFont, XBrushes.Black, 55, orderItemsYPosition + 160); 


        }
 
    }
}
