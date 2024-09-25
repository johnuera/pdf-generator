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

        public static void DrawRightAlignedText(XGraphics gfx, XFont font, string labelText, string valueText,
        double rightMargin, double yPosition, double logoXPosition)
        {
            // Measure the width of the label and value text
            double valueWidth = gfx.MeasureString(valueText, font).Width;

            // Calculate X positions
            double valueX = gfx.PageSize.Width - rightMargin - valueWidth;

            // Draw the label and value
            gfx.DrawString(labelText, font, XBrushes.Black, logoXPosition, yPosition);
            gfx.DrawString(valueText, font, XBrushes.Black, valueX, yPosition);
        }

                public static void DrawRightAlignedLabelAndValue(XGraphics gfx, XFont font, string labelText, string valueText,
        double rightMargin, double yPosition, double logoXPosition)
        {
            // Measure the width of the label and value text
            double valueWidth = gfx.MeasureString(valueText, font).Width;
            double labelWidth = gfx.MeasureString(valueText, font).Width;

            // Calculate X positions
            double valueX = gfx.PageSize.Width - rightMargin - valueWidth;
            double labelValueX = gfx.PageSize.Width - logoXPosition - labelWidth;

            // Draw the label and value
            gfx.DrawString(labelText, font, XBrushes.Black, labelValueX, yPosition);
            gfx.DrawString(valueText, font, XBrushes.Black, valueX, yPosition);
        }
    }

}