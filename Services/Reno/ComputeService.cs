using PdfSharp.Drawing;
using static PDFGenerator.Constants.PdfConstant;
using static PDFGenerator.Constants.FontConstant;
using System.Globalization;
using PDFGenerator.Helpers;

namespace PDFGenerator.Services.Reno
{
    public class ComputeService{
     public static void AddComputation(XGraphics gfx, double orderItemsYPosition, double logoXPosition)
    {
        SubTotal(gfx,orderItemsYPosition,logoXPosition);
    }
    public static void SubTotal(XGraphics gfx, double orderItemsYPosition , double logoXPosition)
    {
        var totalPrice = ComputeTotals(OrderItems);
       var tax = totalPrice * 0.19m;

    // Calculate X position for right alignment
    double pageWidth = gfx.PageSize.Width;
    double rightMargin = 50;

    // Create text strings
    string subtotalText = "Zwischensumme";
    string shippingCostText = "Versandkosten";
    string netAmountText = "Nettobetrag";
    string taxText = "MwSt. 19,0 %";
    string totalAmountText = "Gesamtbetrag";
    CultureInfo de = new CultureInfo("de-DE");

    string totalPriceStr = $"{totalPrice.ToString("F2", de)} €";
    string shippingCostStr = "0,00 €";
    string netAmountStr = $"{(totalPrice - tax).ToString("F2", de)} €";
    string taxAmountStr = $"{tax.ToString("F2", de)} €";
    string totalAmountStr = $"{totalPrice.ToString("F2", de)} €";

    // Draw labels and values with right alignment
    TextHelper.DrawRightAlignedText(gfx, MessageDefaultFont, subtotalText, totalPriceStr, rightMargin, orderItemsYPosition + 30, logoXPosition);
    TextHelper.DrawRightAlignedText(gfx, MessageDefaultFont, shippingCostText, shippingCostStr, rightMargin, orderItemsYPosition + 40, logoXPosition);
    TextHelper.DrawRightAlignedText(gfx, MessageDefaultFont, netAmountText, netAmountStr, rightMargin, orderItemsYPosition + 50, logoXPosition);
    TextHelper.DrawRightAlignedText(gfx, MessageDefaultFont, taxText, taxAmountStr, rightMargin, orderItemsYPosition + 60, logoXPosition);
    TextHelper.DrawRightAlignedText(gfx, MessageBoldFont, totalAmountText, totalAmountStr, rightMargin, orderItemsYPosition + 70, logoXPosition);
}
 

public static  decimal  ComputeTotals(string[,] orders)
    {        
        decimal totalPrice = 0;

        // CultureInfo for parsing decimal values
        var culture = new CultureInfo("de-DE");
        
        for (int i=0;i<=orders.GetLength(0)-1;i++)
        {

            // Parse price
            if (decimal.TryParse(orders[i,6].Replace("€", "").Trim(), NumberStyles.Currency, culture, out decimal price))
            {
                totalPrice += price;
            }
        }

        return totalPrice;
    }

    }



}