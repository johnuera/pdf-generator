using PdfSharp.Drawing;
using static PDFGenerator.Constants.PdfConstant;
using static PDFGenerator.Constants.FontConstant;
using PDFGenerator.Domains;

namespace PDFGenerator.Services.DPL
{
    public class FooterService
    {



        public static void AddCenterFooter(XGraphics gfx, Root data)
        {
            var yPosition = 795;

            // Loop through each line of the footer
            for (int i = 0; i < data.Footer.Center.Length; i++)
            {
                // Get the width of the current string
                var text = data.Footer.Center[i];
                var textWidth = gfx.MeasureString(text, FooterDefaultFont).Width;

                // Calculate the xPosition to center the text
                var xPosition = (gfx.PageSize.Width - textWidth) / 2;

                // Draw the string at the calculated position
                gfx.DrawString(text, FooterDefaultFont, XBrushes.Black, xPosition, yPosition);

                // Move down for the next line
                yPosition += 8;
            }
        }


    }

}