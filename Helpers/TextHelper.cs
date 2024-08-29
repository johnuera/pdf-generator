using PdfSharp.Drawing;


namespace PDFGenerator.Helpers
{
    public class TextHelper
    {
 
        public static void DrawTextLines(XGraphics gfx, string[] lines, double x, double y, XFont font)
        {
            foreach (var line in lines)
            {
                gfx.DrawString(line, font, XBrushes.Black, x, y);
                y += 10;
            }
        }
    }

}