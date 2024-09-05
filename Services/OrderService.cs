using PdfSharp.Drawing;
using static PDFGenerator.Constants.PdfConstant;
using static PDFGenerator.Constants.FontConstant;

using static PDFGenerator.Helpers.TextHelper;
using static PDFGenerator.Helpers.TableHelper;
using PDFGenerator.Domains;

namespace PDFGenerator.Services
{
    public class OrderService
    {

        public static void AddOrderDetails(XGraphics gfx, double xPosition)
        {
            double yPosition = 230;
            DrawTextLines(gfx, OrderDetails, xPosition, yPosition, DefaultFont);
        }

        public static void AddOrderHeader(XGraphics gfx, Root data)
        {
            gfx.DrawString(data.General.InvoiceHeadline, DefaultFontHeader, XBrushes.Black, 50, 300);
        }

        public static double AddOrderItems(XGraphics gfx, int startIndex, int maxItems, double tableY = 320)
        {
            double tableX = 50;
            double tableWidth = gfx.PageSize.Width - 2 * tableX;
            double columnWidth = tableWidth / OrderHeaders.Length;

            // Draw table header
            DrawRow(gfx, OrderHeaders, tableX, tableY, columnWidth, 20, TableHeaderFont, true, false);

            double currentY = tableY + 20;

            // Loop through the specified range of items
            for (int i = 0; i < maxItems; i++)
            {
                int orderIndex = startIndex + i;
                if (orderIndex >= OrderItems.GetLength(0))
                    break;

                bool isLastItem = (orderIndex == OrderItems.GetLength(0) - 1);
                DrawRow(gfx, GetRow(OrderItems, orderIndex), tableX, currentY, columnWidth,
                    40, TableCellFont, false, isLastItem);
                currentY += 40;
            }

            return currentY;
        }


    }

}