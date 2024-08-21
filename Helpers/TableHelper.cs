using PdfSharp.Drawing;


namespace PDFGenerator.Helpers
{
    public class TableHelper{
        
    
   
 
    public static void DrawRow(XGraphics gfx, string[] row, double x, double y, double columnWidth, double rowHeight, XFont font)
    {
        for (int i = 0; i < row.Length; i++)
        {
            double cellX = x + i * columnWidth;
            var cellRect = new XRect(cellX, y, columnWidth, rowHeight);
            gfx.DrawRectangle(XBrushes.White, cellRect);
            gfx.DrawString(row[i], font, XBrushes.Black, cellRect, XStringFormats.Center);
            gfx.DrawRectangle(XPens.Black, cellRect); // Cell border
        }
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