using PDFGenerator.Domains;
using PdfSharp.Drawing;
using static PDFGenerator.Constants.PdfConstant;

namespace PDFGenerator.Helpers.DPL
{
    public class TableHelper
    {
        public static void DrawRow(XGraphics gfx, string[] row, double x, double y,
    double columnWidth, double rowHeight, XFont font, bool isHeader,
    bool isLastItem, Root data)
        {
            var location = isHeader ? XStringFormats.TopLeft : XStringFormats.CenterLeft;

            for (int i = 0; i < row.Length; i++)
            {
                double adjustedColumnWidth = columnWidth;

                // Adjust column widths based on the column index
                switch (i)
                {
                    case 1:
                        adjustedColumnWidth -= 30;
                        break;
                     case 5:
                        adjustedColumnWidth -= 5;
                        break;
                    case 6:
                        adjustedColumnWidth -= 5;
                        break;
                    case 7:
                        adjustedColumnWidth -= 3;
                        break;
                }

                // Special handling for column 4 alignment
                if (i == 4)
                {
                    location = isHeader ? XStringFormats.TopCenter : XStringFormats.Center;
                }

                double cellX = x + i * adjustedColumnWidth;
                var cellRect = new XRect(cellX, y, adjustedColumnWidth, rowHeight);

                // Draw cell content
                gfx.DrawString(row[i], font, XBrushes.Black, cellRect, location);

                // Additional drawing logic for specific columns when not a header
                if (!isHeader)
                {
                    if (i == 5 || i == 6 || i == 8)
                    {
                        gfx.DrawRectangle(new XPen(XColor.FromKnownColor(XKnownColor.Black), 0.01),
                            new XRect(cellX + 10, y + 2.5, 30, rowHeight - 5));
                    }
                    else if (i == 7)
                    {
                        DrawExchangeOptions(gfx, font, data, cellX, y, adjustedColumnWidth, rowHeight, location);
                    }
                }

                // Draw bottom line for header or last item
                if (isHeader || isLastItem)
                {
                    int bottomMargin = isHeader ? 10 : (int)rowHeight;
                    DrawBottomLine(gfx, x, y + (isLastItem ? 10 : 0), adjustedColumnWidth, bottomMargin);
                }
            }
        }

        private static void DrawExchangeOptions(XGraphics gfx, XFont font, Root data, double cellX,
            double y, double adjustedColumnWidth, double rowHeight, XStringFormat location)
        {
            var exchangeYesRect = new XRect(cellX - 20, y, adjustedColumnWidth, rowHeight);
            gfx.DrawString(data.ArticleTable.ExchangeYes, font, XBrushes.Black, exchangeYesRect, location);
            gfx.DrawRectangle(new XPen(XColor.FromKnownColor(XKnownColor.Black), 0.01),
                new XRect(cellX + 10, y + 5, 10, 10));

            var exchangeNoRect = new XRect(cellX + 5, y, adjustedColumnWidth, rowHeight);
            gfx.DrawString(data.ArticleTable.ExchangeNo, font, XBrushes.Black, exchangeNoRect, location);
            gfx.DrawRectangle(new XPen(XColor.FromKnownColor(XKnownColor.Black), 0.01),
                new XRect(cellX + 40, y + 5, 10, 10));
        }



        private static void DrawMultiLineCell(XGraphics gfx, string cellContent,
         XRect cellRect, XFont font)
        {
            string[] lines = cellContent.Split('|');
            double lineHeight = 10; // Vertical spacing between lines
            double newYposition = cellRect.Y;

            foreach (string line in lines)
            {
                var lineRect = new XRect(cellRect.X, newYposition, cellRect.Width, cellRect.Height);
                gfx.DrawString(line, font, XBrushes.Black, lineRect, XStringFormats.TopLeft);
                newYposition += lineHeight;
            }
        }

        private static void DrawBottomLine(XGraphics gfx, double x, double y,
        double columnWidth, double rowHeight)
        {
            gfx.DrawLine(new XPen(XColor.FromKnownColor(XKnownColor.Black), 0.01),
             new XPoint(x, y + rowHeight), new XPoint(gfx.PageSize.Width - 50, y + rowHeight));
        }

        public static string[] GetRow(string[,] array, int rowIndex)
        {
            int columnCount = array.GetLength(1);
            var row = new string[columnCount];
            for (int i = 0; i < columnCount; i++)
            {
                row[i] = array[rowIndex, i];
            }
            return row;
        }
    }
}
