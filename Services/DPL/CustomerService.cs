using PDFGenerator.Domains;
using PDFGenerator.Helpers;
using PdfSharp.Drawing;
using static PDFGenerator.Constants.PdfConstant;
using static PDFGenerator.Constants.FontConstant;
using System.Drawing;
namespace PDFGenerator.Services.DPL
{
    public class CustomerService
    {
        public static void AddCustomerAddress(XGraphics gfx, Root data,double startY = 183.5)
        {
            DrawText(gfx, "RECHNUNGSADRESSE:", 55.3, startY);
            DrawText(gfx, "Vor- und Nachname", 55.3, startY + 11.5);
            DrawText(gfx, "Straße", 55.3, startY + 19.5);
            DrawText(gfx, "Postleitzahl Stadt", 55.3, startY + 27.5);
            DrawText(gfx, "Land", 55.3, startY + 35.5);
        }

        public static void AddInvoiceAddress(XGraphics gfx, Root data,double startY = 183.5)
        {
             DrawText(gfx, "LIEFEADRESSE:", 200, startY);
            DrawText(gfx, "Vor- und Nachname", 200, startY + 11.5);
            DrawText(gfx, "Straße", 200, startY + 19.5);
            DrawText(gfx, "Postleitzahl Stadt", 200, startY + 27.5);
            DrawText(gfx, "Land", 200, startY + 35.5);
        }

        public static void AddOrderDetails(XGraphics gfx, Root data, double xPosition = 246,double startY = 183.5)
        {
            double xValueOffset = 80;
            TextHelper.DrawRightAlignedLabelAndValue(gfx, FooterDefaultFont, "Bestelldatum:", "00.00.2024", 63, startY, 150);
            TextHelper.DrawRightAlignedLabelAndValue(gfx, FooterDefaultFont, "Rechnungsnummer:", "000000", 63, startY + 11.5, 0);

            DrawText(gfx, "Rechnungsnummer:", xPosition, startY + 11.5);
            DrawText(gfx, "000000", xPosition + xValueOffset, startY + 11.5);

            DrawText(gfx, "Kunden ID:", xPosition, startY + 19.5);
            DrawText(gfx, "00000", xPosition + xValueOffset, startY + 19.5);

            DrawText(gfx, "Rechnungsdatum:", xPosition, startY + 27.5);
            DrawText(gfx, "00.00.2024", xPosition + xValueOffset, startY + 27.5);
        }

        private static void DrawText(XGraphics gfx, string text, double xPosition, double yPosition)
        {
            gfx.DrawString(text, SmallBoldFont, XBrushes.Black, xPosition, yPosition);
        }



        public static void AddBarcode(XGraphics gfx, Root data,double startY = 183.5)
        {

            var barCode = BarcodeHelper.CreateBarcode("B12691531", 120, 30);
            if (barCode != null)
            {
                var xPosition = gfx.PageSize.Width - barCode.Size.Width - 55.5;
                gfx.DrawBarCode(barCode, XBrushes.Black, new XPoint(xPosition, startY));

            }


        }
    }
}