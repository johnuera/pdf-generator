using System.ComponentModel.Design.Serialization;
using PdfSharp.Drawing;
using static PDFGenerator.Constants.PdfConstant;
using PDFGenerator.Domains;

namespace PDFGenerator.Helpers
{
    public class TableHelper
    {
        public static void DrawRow(XGraphics gfx, string[] row, double x,
         double y, double columnWidth, double rowHeight, XFont font,
          bool isHeader, bool isLastItem)
        {
            for (int i = 0; i < row.Length; i++)
            {
                double cellX = x + i * columnWidth;
                var cellRect = new XRect(cellX, y, columnWidth, rowHeight);

                if (i == 3 && !isHeader)
                {
                    // Special case for the cell at index 3
                    DrawMultiLineCell(gfx, row[i], cellRect, font);
                }
                else if (i == 2 && !isHeader)
                {
                    // Special case for the cell at index 3
                    DrawItemImage(gfx,   cellX, y, rowHeight,columnWidth);
                }
                else
                {
                    // Default drawing for other cells
                    gfx.DrawString(row[i], font, XBrushes.Black, cellRect, XStringFormats.TopCenter);

                    if (isHeader || (i == row.Length - 1 && isLastItem))
                    {
                        // Draw the bottom line if it's a header or last item
                        DrawBottomLine(gfx, x, y, columnWidth, 10);
                    }
                }
            }
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
            gfx.DrawLine(new XPen(XColor.FromKnownColor(XKnownColor.Black), 0.1),
             new XPoint(x, y + rowHeight), new XPoint(gfx.PageSize.Width - 50, y + rowHeight));
        }

        private static void DrawItemImage(XGraphics gfx, double x, double y,
         double columnWidth, double rowHeight)
          {
            var imagePath = $"{FolderPath}kilagoo/shoes.png";
            var image = XImage.FromFile(imagePath);
            double xPosition = x;
            gfx.DrawImage(image, xPosition, y,columnWidth-10,rowHeight-10);
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
