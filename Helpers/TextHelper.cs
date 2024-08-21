using PdfSharp.Drawing;
using static PDFGenerator.Constants.PdfConstant;
using static PDFGenerator.Constants.FontConstant;


namespace PDFGenerator.Helpers
{
    public class TextHelper{
        
    
   

        public static void DrawTextLines(XGraphics gfx, string[] lines, double x, ref double y, XFont font)
    {
        foreach (var line in lines)
        {
            gfx.DrawString(line, font, XBrushes.Black, x, y);
            y += 10;
        }
    }
    }

}