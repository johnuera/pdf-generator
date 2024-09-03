
using static PDFGenerator.Helpers.TextHelper;
using static PDFGenerator.Helpers.TableHelper;
using PDFGenerator.Domains;
using PdfSharp.Drawing;
using static PDFGenerator.Constants.PdfConstant;
using static PDFGenerator.Constants.FontConstant;

namespace PDFGenerator.Services
{
    public class MessageService
    {
        public static void AddThankYouMessage(XGraphics gfx, double orderItemsYPosition, Root data)
        {
            gfx.DrawString(data.InvoiceDetails.ThankYou, MessageDefaultFont, XBrushes.Black, 50, orderItemsYPosition + 100);
        }

        public static void AddPaymentMethod(XGraphics gfx, double orderItemsYPosition, Root data)
        {
            gfx.DrawString(PaymentMethod, MessageBoldFont, XBrushes.Black, 50, orderItemsYPosition + 120);
        }

        public static void AddReturnMessage(XGraphics gfx, double orderItemsYPosition, Root data)
        {
            gfx.DrawString(ReturnInstructions[0], MessageBoldFont, XBrushes.Black, 50, orderItemsYPosition + 140);
            gfx.DrawString(ReturnInstructions[1], MessageDefaultFont, XBrushes.Black, 50, orderItemsYPosition + 150);
            gfx.DrawString(ReturnInstructions[2], MessageDefaultFont, XBrushes.Black, 50, orderItemsYPosition + 160);
            gfx.DrawString(ReturnInstructions[3], MessageDefaultFont, XBrushes.Black, 50, orderItemsYPosition + 190);



        }

        public static void AddQRCode(XGraphics gfx, double orderItemsYPosition, Root data)
        {
            var imagePath = $"{FolderPath}{data.General.ClientName}/qrSpace.png";
            var image = XImage.FromFile(imagePath);
            double xPosition = gfx.PageSize.Width - 190;
            gfx.DrawImage(image, xPosition, orderItemsYPosition + 120, 140, 65);
        }

        public static void AddSignature(XGraphics gfx, double orderItemsYPosition, Root data)
        {
            var imagePath = $"{FolderPath}{data.General.ClientName}/signature-kilagoo.png";
            var image = XImage.FromFile(imagePath);
            gfx.DrawImage(image, 50, orderItemsYPosition + 190, 150, 35);
        }

    }
}
