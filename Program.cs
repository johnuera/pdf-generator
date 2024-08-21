using System;
using System.Linq;
using PdfSharp.Pdf;
using PdfSharp.Drawing;
using static PDFGenerator.Constants.PdfConstant;
using static PDFGenerator.Constants.FontConstant;

class Program
{
    static void Main()
    {
        // Create a PDF document and a page
        using (var document = new PdfDocument())
        {
            document.Info.Title = "Created with PDFsharp";
            var page = document.AddPage();
            page.Size = PdfSharp.PageSize.A4;

            // Create graphics object
            using (var gfx = XGraphics.FromPdfPage(page))
            {
                // Add content
                double imageXPosition = AddLogo(gfx);
                AddCompanyDetails(gfx);
                AddCustomerDetails(gfx);
                AddCompanyDetailsUpperRight(gfx, imageXPosition);
                AddCompanyContacts(gfx, imageXPosition);
                AddOrderDetails(gfx, imageXPosition);
                AddOrderHeader(gfx);
                AddOrderItems(gfx);
            }

            // Save the document
            document.Save("HelloWorld.pdf");
            Console.WriteLine("PDF file saved to: HelloWorld.pdf");
        }
    }

    private static double AddLogo(XGraphics gfx)
    {
        var image = XImage.FromFile(LogoPath);
        double xPosition = gfx.PageSize.Width - (image.PixelWidth / 5) - 20;
        gfx.DrawImage(image, xPosition, 50, image.PixelWidth / 5, image.PixelHeight / 5);
        return xPosition;
    }

    private static void AddCustomerDetails(XGraphics gfx)
    {
        double yPosition = 170;
        DrawTextLines(gfx, CustomerDetails, 50, ref yPosition, DefaultFont);
    }

    private static void AddCompanyDetails(XGraphics gfx)
    {
        gfx.DrawString(string.Join(", ", CompanyDetails), DefaultFontBold, XBrushes.Black, 50, 150);
    }

    private static void AddCompanyDetailsUpperRight(XGraphics gfx, double xPosition)
    {
        double yPosition = 150;
        DrawTextLines(gfx, CompanyDetails, xPosition, ref yPosition, DefaultFontBold);
    }

    private static void AddCompanyContacts(XGraphics gfx, double xPosition)
    {
        double yPosition = 200;
        DrawTextLines(gfx, CompanyContacts, xPosition, ref yPosition, DefaultFont);
    }

    private static void AddOrderDetails(XGraphics gfx, double xPosition)
    {
        double yPosition = 240;
        DrawTextLines(gfx, OrderDetails, xPosition, ref yPosition, DefaultFont);
    }

    private static void AddOrderHeader(XGraphics gfx)
    {
        gfx.DrawString(DeliveryNote, DefaultFontHeader, XBrushes.Black, 50, 300);
    }

    private static void AddOrderItems(XGraphics gfx)
    {
        double tableX = 50;
        double tableY = 320;
        double tableWidth = gfx.PageSize.Width - 2 * tableX;
        double columnWidth = tableWidth / OrderHeaders.Length;

        DrawRow(gfx, OrderHeaders, tableX, tableY, columnWidth, 20, TableHeaderFont);

        double currentY = tableY + 20;
        for (int i = 0; i < OrderItems.GetLength(0); i++)
        {
            DrawRow(gfx, GetRow(OrderItems, i), tableX, currentY, columnWidth, 40, TableCellFont);
            currentY += 40;
        }
    }

    private static void DrawTextLines(XGraphics gfx, string[] lines, double x, ref double y, XFont font)
    {
        foreach (var line in lines)
        {
            gfx.DrawString(line, font, XBrushes.Black, x, y);
            y += 10;
        }
    }

    private static void DrawRow(XGraphics gfx, string[] row, double x, double y, double columnWidth, double rowHeight, XFont font)
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

    private static string[] GetRow(string[,] array, int rowIndex)
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
