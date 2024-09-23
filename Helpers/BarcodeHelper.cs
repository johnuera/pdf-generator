using PdfSharp.Drawing;
using PdfSharp.Drawing.BarCodes;


namespace PDFGenerator.Helpers
{
    public class BarcodeHelper
    {
 
        public static BarCode? CreateBarcode( string OrderId,
         double width, double height)
        {
            if(OrderId==""){
                return null;
            }
            BarCode barCode = new  Code3of9Standard(OrderId, new XSize(width,height) , CodeDirection.LeftToRight);
            return barCode;
        }

    }
    }