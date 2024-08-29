using PdfSharp.Fonts;

namespace PDFGenerator.Helpers
{
    /// <summary>
    /// Maps font requests for the Calibri font to a set of specific font files.
    /// These fonts should be embedded as resources in your assembly.
    /// </summary>
    public class CalibriFontResolver : IFontResolver
    {
        // ReSharper disable InconsistentNaming

        /// <summary>
        /// The font family names that can be used in the constructor of XFont.
        /// Used in the first parameter of ResolveTypeface.
        /// Family names are given in lower case because the implementation of
        /// CalibriFontResolver ignores case.
        /// </summary>
        public static class FamilyNames
        {
            public const string Calibri = "calibri";
            public const string CalibriBold = "calibri bold";
            public const string CalibriItalic = "calibri italic";
            public const string CalibriBoldItalic = "calibri bold italic";
        }

        /// <summary>
        /// The internal names that uniquely identify the font faces.
        /// Used in the first parameter of the FontResolverInfo constructor.
        /// </summary>
        static class FaceNames
        {
            public const string Calibri = "Calibri";
            public const string CalibriBold = "CalibriBold";
            public const string CalibriItalic = "CalibriItalic";
            public const string CalibriBoldItalic = "CalibriBoldItalic";
        }

        // ReSharper restore InconsistentNaming

        /// <summary>
        /// Selects a physical font face based on the specified information
        /// of a required typeface.
        /// </summary>
        /// <param name="familyName">Name of the font family.</param>
        /// <param name="isBold">Set to <c>true</c> when a bold font face
        ///  is required.</param>
        /// <param name="isItalic">Set to <c>true</c> when an italic font face 
        /// is required.</param>
        /// <returns>
        /// Information about the physical font, or null if the request cannot be satisfied.
        /// </returns>
        public FontResolverInfo? ResolveTypeface(string familyName, bool isBold, bool isItalic)
        {
            string lowercaseFamilyName = familyName.ToLowerInvariant();

            if (lowercaseFamilyName == FamilyNames.Calibri)
            {
                if (isBold && isItalic)
                    return new FontResolverInfo(FaceNames.CalibriBoldItalic);
                if (isBold)
                    return new FontResolverInfo(FaceNames.CalibriBold);
                if (isItalic)
                    return new FontResolverInfo(FaceNames.CalibriItalic);
                return new FontResolverInfo(FaceNames.Calibri);
            }

            return PlatformFontResolver.ResolveTypeface(familyName, isBold, isItalic);
        }

        /// <summary>
        /// Gets the bytes of a physical font face with specified face name.
        /// </summary>
        /// <param name="faceName">A face name previously retrieved by ResolveTypeface.</param>
        /// <returns>
        /// The bits of the font.
        /// </returns>
        public byte[]? GetFont(string faceName)
        {
            return faceName switch
            {
                FaceNames.Calibri => PDFGenerator.Helpers.FontDataHelper.Calibri,
                FaceNames.CalibriBold =>  PDFGenerator.Helpers.FontDataHelper.CalibriBold,
                FaceNames.CalibriItalic =>  PDFGenerator.Helpers.FontDataHelper.CalibriItalic,
                FaceNames.CalibriBoldItalic =>  PDFGenerator.Helpers.FontDataHelper.CalibriBoldItalic,
                _ => null
            };
        }
    }
}
