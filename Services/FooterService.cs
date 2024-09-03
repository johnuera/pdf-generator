using PdfSharp.Drawing;
using static PDFGenerator.Constants.PdfConstant;
using static PDFGenerator.Constants.FontConstant;
using static PDFGenerator.Helpers.TextHelper;

namespace PDFGenerator.Services
{
    public class FooterService{
    
    public static void AddLeftFooter(XGraphics gfx)
    {   
        var yPosition = 780;
        gfx.DrawString(FooterCompanyInfo[0], FooterBoldFont, XBrushes.Black, 50,yPosition );
        yPosition+=7;
        for (int i =1;i<FooterCompanyInfo.Length;i++)         
            {
                gfx.DrawString(FooterCompanyInfo[i], FooterDefaultFont, XBrushes.Black, 50, yPosition);
                yPosition += 7;
            }
 
    }

    public static void AddRightFooter(XGraphics gfx)
    {   
        var yPosition = 780;
        var xPosition = gfx.PageSize.Width - 200;
        gfx.DrawString(FooterCompanyDetails[0], FooterBoldFont, XBrushes.Black,xPosition ,yPosition );
        yPosition+=7;
        for (int i =1;i<FooterCompanyDetails.Length;i++)         
            {
                gfx.DrawString(FooterCompanyDetails[i], FooterDefaultFont, XBrushes.Black,  xPosition, yPosition);
                if(FooterCompanyDetails.Length-2==i){
                    yPosition += 7;

                }
               
                yPosition += 7;
               

            }
 
    }
     
    }

}