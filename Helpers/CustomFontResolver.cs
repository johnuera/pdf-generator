using PdfSharpCore.Fonts;
using System.IO;
using System.Reflection;
namespace PDFGenerator.Helpers
{
    public class CustomFontResolver : IFontResolver
    {
        public static readonly CustomFontResolver Instance = new CustomFontResolver();
    // Implement the DefaultFontName property
        public string DefaultFontName => "Calibri";
        public byte[] GetFont(string faceName)
        {
            switch (faceName)
            {
                case "Calibri#":
                    return LoadFontData("PDFGenerator.Fonts.vista.calibri.ttf");
                case "Calibri-Bold#":
                    return LoadFontData("PDFGenerator.Fonts.vista.calibrib.ttf");
                // Add other cases as necessary for bold, italic, etc.
            }

            return null;
        }

        public FontResolverInfo ResolveTypeface(string familyName, bool isBold, bool isItalic)
        {
            Console.WriteLine(familyName);
            if (familyName == "Calibri")
            {
                if (isBold)
                {
                    return new FontResolverInfo("Calibri-Bold#");
                }

                return new FontResolverInfo("Calibri#");
            }

            // Fallback to some other default font
            return PlatformFontResolver.ResolveTypeface(familyName, isBold, isItalic);
        }

        private static byte[] LoadFontData(string resourceName)
        {
            using (var stream = typeof(CustomFontResolver).Assembly.GetManifestResourceStream(resourceName))
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