using PdfSharp.Drawing;
using static PDFGenerator.Constants.PdfConstant;
using static PDFGenerator.Constants.FontConstant;

using static PDFGenerator.Helpers.TextHelper;
using static PDFGenerator.Helpers.TableHelper;

namespace PDFGenerator.Services
{
    public class OrderService{
        
    public static void AddOrderDetails(XGraphics gfx, double xPosition)
    {
        double yPosition = 240;
        DrawTextLines(gfx, OrderDetails, xPosition, ref yPosition, DefaultFont);
    }

    public static void AddOrderHeader(XGraphics gfx)
    {
        gfx.DrawString(DeliveryNote, DefaultFontHeader, XBrushes.Black, 50, 300);
    }

    public static void AddOrderItems(XGraphics gfx)
    {
        double tableX = 50;
        double tableY = 320;
        double tableWidth = gfx.PageSize.Width - 2 * tableX;
        double columnWidth = tableWidth / OrderHeaders.Length;

        DrawRow(gfx, OrderHeaders, tableX, tableY, columnWidth, 20, TableHeaderFont);

        double currentY = tableY + 20;
        for (int i = 0; i < OrderItems.GetLength(0); i++)
        {
            DrawRow(gfx, GetRow(OrderItems, i), tableX, currentY, columnWidth, 40, TableCellFont);
            currentY += 40;
        }
    }

    }

}