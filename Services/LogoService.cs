using PDFGenerator.Domains;
using PdfSharp.Drawing;
using static PDFGenerator.Constants.PdfConstant;
namespace PDFGenerator.Services
{
    public class LogoService{
        
    public static double AddLogo(XGraphics gfx, Root data)
        {
            var imagePath = $"{FolderPath}{data.General.ClientName}/logo-{data.General.ClientName}.png";
            var image = XImage.FromFile(imagePath);
            double xPosition = gfx.PageSize.Width - image.PixelWidth;
            gfx.DrawImage(image, xPosition, 20);
            return xPosition;
        }

    }

}