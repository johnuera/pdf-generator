using PDFGenerator.Domains;
using PdfSharp.Drawing;
using static PDFGenerator.Constants.PdfConstant;
using static PDFGenerator.Constants.FontConstant;

namespace PDFGenerator.Services.Reno
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
            gfx.DrawString(data.PaymentText.ReturnHint, MessageBoldFont, XBrushes.Black, 50, orderItemsYPosition + 140);
            gfx.DrawString(data.PaymentText.ReturnText1, MessageDefaultFont, XBrushes.Black, 50, orderItemsYPosition + 150);
            gfx.DrawString(data.PaymentText.ReturnText2, MessageDefaultFont, XBrushes.Black, 50, orderItemsYPosition + 160);
            gfx.DrawString(data.PaymentText.Regards, MessageDefaultFont, XBrushes.Black, 50, orderItemsYPosition + 190);



        }

        public static void AddQRCode(XGraphics gfx, double orderItemsYPosition, Root data)
        {
            var imagePath = $"{FolderPath}{data.General.ClientName}/qrSpace.png";
            var image = XImage.FromFile(imagePath);
            double xPosition = gfx.PageSize.Width - 190;
            gfx.DrawImage(image, xPosition, orderItemsYPosition + 120, 120, 75);
            //For Kilago
            //gfx.DrawImage(image, xPosition, orderItemsYPosition + 120, 140, 65);

        }

        public static void AddSignature(XGraphics gfx, double orderItemsYPosition, Root data)
        {
            if(data.General.ClientName=="kilago"){
            var imagePath = $"{FolderPath}{data.General.ClientName}/signature-kilagoo.png";
            var image = XImage.FromFile(imagePath);
            gfx.DrawImage(image, 50, orderItemsYPosition + 190, 150, 35);
            }

        }

    }
}
