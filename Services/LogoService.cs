using PdfSharp.Drawing;
using static PDFGenerator.Constants.PdfConstant;
namespace PDFGenerator.Services
{
    public class LogoService{
        
    public static double AddLogo(XGraphics gfx)
    {
        var image = XImage.FromFile(LogoPath);
        double xPosition = gfx.PageSize.Width - (image.PixelWidth / 5) - 20;
        gfx.DrawImage(image, xPosition, 50, image.PixelWidth / 5, image.PixelHeight / 5);
        return xPosition;
    }
    }

}