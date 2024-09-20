using PDFGenerator.Domains;
using PdfSharp.Drawing;
using static PDFGenerator.Constants.PdfConstant;
using static PDFGenerator.Constants.FontConstant;
using static PDFGenerator.Helpers.DPL.TableHelper;
using PDFGenerator.Helpers;
using PdfSharp.UniversalAccessibility.Drawing;

namespace PDFGenerator.Services.DPL
{
    public class ReturnService
    {


        public static double AddReturnItems(XGraphics gfx, Root data, int startIndex, int maxItems, double tableY = 320)
        {
            double tableX = 55;
            double tableWidth = gfx.PageSize.Width - (2 * tableX);
            string[] orderHeader = {
                data.ArticleTable.HeaderPos,
                data.ArticleTable.HeaderName,
                data.ArticleTable.HeaderNo,
                data.ArticleTable.HeaderColor,
                data.ArticleTable.HeaderSize,
                data.ArticleTable.HeaderQuantity,
                data.ArticleTable.HeaderReasonForReturn,
                data.ArticleTable.HeaderExchange,
                data.ArticleTable.HeaderNewSize,
            };
            double columnWidth = tableWidth / orderHeader.Length;

            // Draw table header
            DrawRow(gfx, orderHeader, tableX, tableY, columnWidth, 20, ReturnTableCellFont, true, false, data);

            double currentY = tableY + 20;

            // Loop through the specified range of items
            for (int i = 0; i < maxItems; i++)
            {
                int orderIndex = startIndex + i;
                if (orderIndex >= ReturnItems.GetLength(0))
                    break;

                bool isLastItem = orderIndex == ReturnItems.GetLength(0) - 1;
                DrawRow(gfx, GetRow(ReturnItems, orderIndex), tableX, currentY, columnWidth,
                    20, ReturnTableCellFont, false, isLastItem, data);
                currentY += 20;
            }

            return currentY;
        }

        public static void AddReturnReason(XGraphics gfx, Root data, double returnItemYPosition)
        {
            // Draw the header
            gfx.DrawString(data.ArticleTable.HeaderReasonForReturn, ReturnTableCellBoldFont,
                XBrushes.Black, 55.5, returnItemYPosition + 40);

            // Draw the return hint text
            TextHelper.DrawTextLines(gfx, data.ReturnText.ReturnHint, 55.5, returnItemYPosition + 48, ReturnTableCellFont);

            // Grouped return reasons for structured drawing
            string[][] returnReasonsGroups = [
                [data.ReturnText.Reason1, data.ReturnText.Reason2, data.ReturnText.Reason3],
                [data.ReturnText.Reason4, data.ReturnText.Reason5, data.ReturnText.Reason6],
                [data.ReturnText.Reason7, data.ReturnText.Reason8, data.ReturnText.Reason9]
            ];

            double[] xPositions = { 160, 320, 440 };  // X positions for each group of return reasons

            // Loop through each group and draw the return reasons
            for (int i = 0; i < returnReasonsGroups.Length; i++)
            {
                TextHelper.DrawTextLines(gfx, returnReasonsGroups[i], xPositions[i], returnItemYPosition + 48, ReturnTableCellFont);
            }
        }


    }
}