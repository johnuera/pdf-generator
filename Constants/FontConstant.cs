using PdfSharp.Drawing; // Ensure this is included for XFont

namespace PDFGenerator.Constants
{
    public static class FontConstant
    {

        public static readonly XFont DefaultFont = new XFont("Calibri", 9, XFontStyleEx.Regular);
        public static readonly XFont DefaultFontHeader = new XFont("Calibri", 20, XFontStyleEx.Regular);

        public static readonly XFont DefaultFontBold = new XFont("Calibri", 9, XFontStyleEx.Bold);

        public static readonly XFont TableHeaderFont = new XFont("Calibri", 6, XFontStyleEx.Bold);
        public static readonly XFont TableCellFont = new XFont("Calibri", 7, XFontStyleEx.Regular);
    }
}
