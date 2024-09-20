using PdfSharp.Drawing;
using static PDFGenerator.Constants.PdfConstant;

namespace PDFGenerator.Helpers.Reno
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
                    DrawItemImage(gfx,   cellX, y, columnWidth,rowHeight);
                }
                else
                {
                    var location = XStringFormats.TopLeft;
                    if(i>2){
                        location = XStringFormats.TopCenter;
                    }
                    if(i>4){
                        location = XStringFormats.TopRight;
                    }
                    // Default drawing for other cells
                    gfx.DrawString(row[i], font, XBrushes.Black, cellRect, location);

                    //if (isHeader || (i == row.Length - 1 && isLastItem))
                    if (isHeader ||  isLastItem)
                    {
                        var bottomMargin = 10;
                        if(isLastItem){
                            bottomMargin = (int)rowHeight;
                        }
                        // Draw the bottom line if it's a header or last item
                        DrawBottomLine(gfx, x, y, columnWidth, bottomMargin);
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

            // Calculate the scaling factor to maintain the aspect ratio
            double imageAspect = image.PixelWidth / (double)image.PixelHeight;
            double boxAspect = columnWidth / rowHeight;

            double scaledWidth, scaledHeight;

            if (imageAspect > boxAspect)
            {
                // Image is wider relative to the box, fit by width
                scaledWidth = columnWidth - 20;
                scaledHeight = (columnWidth - 20) / imageAspect;
            }
            else
            {
                // Image is taller relative to the box, fit by height
                scaledWidth = (rowHeight - 20) * imageAspect;
                scaledHeight = rowHeight - 20;
            }

            // Draw the image at the specified location with the calculated size
            gfx.DrawImage(image, x, y, scaledWidth, scaledHeight);
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
