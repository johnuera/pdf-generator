using PdfSharp.Drawing;
using static PDFGenerator.Constants.PdfConstant;
using static PDFGenerator.Constants.FontConstant;
using PDFGenerator.Domains;

namespace PDFGenerator.Services
{
    public class FooterService{
    
    public static void AddLeftFooter(XGraphics gfx,Root data)
    {   
        var yPosition = 780;
        gfx.DrawString(data.Footer.Left[0], FooterBoldFont, XBrushes.Black, 50,yPosition );
        yPosition+=7;
        for (int i =1;i<data.Footer.Left.Length;i++)         
            {
                gfx.DrawString(data.Footer.Left[i], FooterDefaultFont, XBrushes.Black, 50, yPosition);
                yPosition += 7;
            }
 
    }

    public static void AddRightFooter(XGraphics gfx,Root data)
    {   
        var yPosition = 780;
        var xPosition = gfx.PageSize.Width - 200;
        gfx.DrawString(data.Footer.Right[0], FooterBoldFont, XBrushes.Black,xPosition ,yPosition );
        yPosition+=7;
        for (int i =1;i<data.Footer.Right.Length;i++)         
            {
                gfx.DrawString(data.Footer.Right[i], FooterDefaultFont, XBrushes.Black,  xPosition, yPosition);
                if(data.Footer.Right.Length-2==i){
                    yPosition += 7;

                }
               
                yPosition += 7;
               

            }
 
    }
     
    }

}