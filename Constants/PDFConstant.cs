using PdfSharp.Drawing; // Ensure this is included for XFont

namespace PDFGenerator.Constants
{
    public static class PdfConstant
    {
        // Constants for file paths and fonts
        public const string LogoPath = "kilagoo-logo.png";
 

        // Customer details
        public static readonly string[] CustomerDetails =
        {
            "Frau Gisela Zunker",
            "Martin-Luther-Str. 6",
            "53844 Troisdorf"
        };

        // Company details
         public static readonly string[] CompanyDetails =
       {
            "kilagoo",
            "Industriestr. 41",
            "23879 Mölln",
        };

        public static readonly string[] CompanyContacts =
        {
            "Tel.: 05130/9069061",
            "kontakt@kilagoo.com",
            "www.kilagoo.com"
        };

        public static readonly string[] OrderDetails =
        {
                    "Rechnungsdatum: 19.08.2024",
                    "Kundennummer: 477289",
                    "Rechnungsnummer: 245817",
                    "Bestellnummer: 245817"
        };

        public static readonly string DeliveryNote = "Rechnung / Lieferschein";
       public static readonly string[] OrderHeaders = { "Pos", "Artikelnummer", "Artikel", "Bezeichnung", "Menge", "Preis", "Summe" };

        public static readonly string[,] OrderItems = {
                        { "1", "123456", "Example Item", "Ara Damen Sandale Grösse: 38.0 Farbe: weiß", "2", "10.00", "20.00" },
                        { "2", "789012", "Another Item", "Another Description", "1", "15.00", "15.00" }
                    };

    }
}
