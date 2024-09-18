using PdfSharp.Drawing; // Ensure this is included for XFont

namespace PDFGenerator.Constants
{
    public static class FontConstant
    {

        public static readonly XFont DefaultFont = new XFont("Arial", 9, XFontStyleEx.Regular);
        public static readonly XFont DefaultFontHeader = new XFont("Arial", 14, XFontStyleEx.Regular);
        public static readonly XFont FontHeaderBold = new XFont("Arial", 13, XFontStyleEx.Bold);

        public static readonly XFont DefaultFontBold = new XFont("Arial", 9, XFontStyleEx.Bold);
        public static readonly XFont TableHeaderFont = new XFont("Arial", 8, XFontStyleEx.Bold);
        public static readonly XFont TableCellFont = new XFont("Arial", 7, XFontStyleEx.Regular);
        public static readonly XFont FooterDefaultFont = new XFont("Arial", 7, XFontStyleEx.Regular);
        public static readonly XFont FooterBoldFont = new XFont("Arial", 7, XFontStyleEx.Bold);
        public static readonly XFont MessageDefaultFont = new XFont("Arial", 9, XFontStyleEx.Regular);
        public static readonly XFont MessageBoldFont = new XFont("Arial", 9, XFontStyleEx.Bold);
        public static readonly XFont SmallDefaultFont = new XFont("Arial", 6, XFontStyleEx.Regular);
        public static readonly XFont SmallBoldFont = new XFont("Arial", 7, XFontStyleEx.Bold);

    }
}
