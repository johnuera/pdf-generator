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

        public static void AddCustomerAddress(XGraphics gfx, Root data)
        {

            gfx.DrawString("RECHNUNGSADRESSE:", SmallBoldFont, XBrushes.Black, 55.3, 183.5);
            gfx.DrawString("Vor- und Nachname", SmallBoldFont, XBrushes.Black, 55.3, 195);
            gfx.DrawString("Straße", SmallBoldFont, XBrushes.Black, 55.3, 203);
            gfx.DrawString("Postleitzahl Stadt", SmallBoldFont, XBrushes.Black, 55.3, 211);
            gfx.DrawString("Land", SmallBoldFont, XBrushes.Black, 55.3, 219);

        }

        public static void AddOrderDetails(XGraphics gfx, Root data)
        {
            var xPosition = 246;

            gfx.DrawString("Bestelldatum:", SmallBoldFont, XBrushes.Black, xPosition, 183.5);
            gfx.DrawString("00.00.2024", SmallBoldFont, XBrushes.Black, xPosition + 80, 183.5);

            gfx.DrawString("Rechnungsnummer:", SmallBoldFont, XBrushes.Black, xPosition, 195);
            gfx.DrawString("000000", SmallBoldFont, XBrushes.Black, xPosition + 80, 195);

            gfx.DrawString("Kunden ID:", SmallBoldFont, XBrushes.Black, xPosition, 203);
            gfx.DrawString("00000", SmallBoldFont, XBrushes.Black, xPosition + 80, 203);

            gfx.DrawString("Rechnungsdatum:", SmallBoldFont, XBrushes.Black, xPosition, 211);
            gfx.DrawString("00.00.2024", SmallBoldFont, XBrushes.Black, xPosition + 80, 211);


        }


                public static void AddBarcode(XGraphics gfx, Root data)
        {
          
                var barCode = BarcodeHelper.CreateBarcode("B12691531",120, 30);
                if(barCode!=null){
                        var xPosition = gfx.PageSize.Width - barCode.Size.Width-55.5;
                         gfx.DrawBarCode(barCode, XBrushes.Black,new XPoint(xPosition,180));

                }


        }
    }
}