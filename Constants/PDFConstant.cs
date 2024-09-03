namespace PDFGenerator.Constants
{
    public static class PdfConstant
    {
        // Constants for file paths and fonts
        
        public const string FolderPath = "C:\\fuljoyment\\invoices\\";
        public const string PaymentMethod = "Zahlungsart: Paypal";


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

        public static readonly string[] FooterCompanyInfo =
        {
            "Kienast Schuhhandels GmbH & Co. KG",
            "An der Autobahn 15",
            "30900 Wedemark",
            "Amtsgericht Hannover HRA 200934",
            "USt-IdNr.: DE814939914"
        };

        public static readonly string[] FooterCompanyDetails =  
        {
            "Persönlich haftende Gesellschafterin:",
            "Kienast Verwaltungs GmbH",
            "Amtsgericht Hannover HRB 202679",
            "Geschäftsführer: Peter-Phillip Kienast, Marco Klin"
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
            public static readonly string[] ReturnInstructions =  
            {
                "Du möchtest deine kilagoo Produkte zurückgeben?",
                "Bitte verwende für die Anmeldung deiner Retoure das Retourenportal auf kilagoo.com",
                "und gib dort deine Bestellnummer und die bei der Bestellung verwendete Mailadresse an.",
                "Liebe Grüße"
            };

        public static readonly string[,] OrderItems = {
                        { "1", "100-234567", "Summer Dress", "Lightweight Cotton Dress | Size: M | Color: Floral", "1", "50,00 €", "50,00 €" },
                        { "2", "200-345678", "Running Shoes", "Men's Running Shoes | Size: 42.0 | Color: Blue", "2", "75,00 €", "150,00 €" },
                        { "3", "300-456789", "Evening Gown", "Elegant Silk Evening Gown | Size: L | Color: Red", "1", "200,00 €", "200,00 €" },
                        { "4", "400-567890", "Casual Sneakers", "Women's Casual Sneakers | Size: 38.0 | Color: White", "1", "60,00 €", "60,00 €" },
                        { "5", "500-678901", "Beach Dress", "Comfortable Beach Dress | Size: S | Color: Blue Stripes", "2", "40,00 €", "80,00 €" },
                        { "6", "600-789012", "Formal Shoes", "Leather Formal Shoes | Size: 43.0 | Color: Black", "1", "120,00 €", "120,00 €" },
                        { "7", "700-890123", "Cocktail Dress", "Chic Cocktail Dress | Size: M | Color: Black", "1", "85,00 €", "85,00 €" },
                        { "8", "800-901234", "Boots", "Winter Boots | Size: 39.0 | Color: Brown", "1", "95,00 €", "95,00 €" },
                        // { "9", "900-012345", "Summer Sandals", "Comfortable Summer Sandals | Size: 37.0 | Color: Tan", "3", "30,00 €", "90,00 €" },
                        // { "10", "100-123456", "Maxi Dress", "Flowy Maxi Dress | Size: L | Color: Green", "1", "65,00 €", "65,00 €" },

                        // { "11", "200-234567", "Summer Dress", "Lightweight Cotton Dress | Size: M | Color: Floral", "1", "50,00 €", "50,00 €" },
                        // { "12", "300-345678", "Running Shoes", "Men's Running Shoes | Size: 42.0 | Color: Blue", "2", "75,00 €", "150,00 €" },
                        // { "13", "400-456789", "Evening Gown", "Elegant Silk Evening Gown | Size: L | Color: Red", "1", "200,00 €", "200,00 €" },
                        // { "14", "500-567890", "Casual Sneakers", "Women's Casual Sneakers | Size: 38.0 | Color: White", "1", "60,00 €", "60,00 €" },
                        // { "15", "600-678901", "Beach Dress", "Comfortable Beach Dress | Size: S | Color: Blue Stripes", "2", "40,00 €", "80,00 €" },
                        // { "16", "700-789012", "Formal Shoes", "Leather Formal Shoes | Size: 43.0 | Color: Black", "1", "120,00 €", "120,00 €" },
                        // { "17", "800-890123", "Cocktail Dress", "Chic Cocktail Dress | Size: M | Color: Black", "1", "85,00 €", "85,00 €" },
                        // { "18", "900-901234", "Boots", "Winter Boots | Size: 39.0 | Color: Brown", "1", "95,00 €", "95,00 €" },
                        // { "19", "100-012345", "Summer Sandals", "Comfortable Summer Sandals | Size: 37.0 | Color: Tan", "3", "30,00 €", "90,00 €" },
                        // { "20", "200-123456", "Maxi Dress", "Flowy Maxi Dress | Size: L | Color: Green", "1", "65,00 €", "65,00 €" }

    };

    }
}
