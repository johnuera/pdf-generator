namespace PDFGenerator.Helpers
{
    public static class FontDataHelper
    {
        public static byte[] Calibri => LoadFontData("PDFGenerator.Fonts.vista.calibri.ttf");
        public static byte[] CalibriBold => LoadFontData("PDFGenerator.Fonts.vista.calibrib.ttf");
        public static byte[] CalibriItalic => LoadFontData("PDFGenerator.Fonts.vista.calibrii.ttf");
        public static byte[] CalibriBoldItalic => LoadFontData("PDFGenerator.Fonts.vista.calibriz.ttf");

        private static byte[] LoadFontData(string resourceName)
        {
            using (var stream = typeof(FontDataHelper).Assembly.GetManifestResourceStream(resourceName))
            {
                if (stream == null)
                    throw new InvalidOperationException($"Resource '{resourceName}' not found.");
                
                byte[] data = new byte[stream.Length];
                stream.Read(data, 0, (int)stream.Length);
                return data;
            }
        }
    }
}
