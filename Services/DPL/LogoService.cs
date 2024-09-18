using PDFGenerator.Domains;
using PdfSharp.Drawing;
using static PDFGenerator.Constants.PdfConstant;
namespace PDFGenerator.Services.DPL
{
    public class LogoService{
        
    public static void AddLogo(XGraphics gfx, Root data)
        {
            var imagePath = $"{FolderPath}{data.General.ClientCode}/{data.General.ClientCode}-logo2.png";
            var image = XImage.FromFile(imagePath);
            
            gfx.DrawImage(image, 55, 72.5,125,35.5);
         }

    }

}