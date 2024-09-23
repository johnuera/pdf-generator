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
        public static readonly string[] ReturnHeaders = { "Pos", "Artikelnummer", "Artikel", "Bezeichnung", "Menge", "Preis", "Summe" };

        public static readonly string[] ReturnInstructions =
        {
                "Du möchtest deine kilagoo Produkte zurückgeben?",
                "Bitte verwende für die Anmeldung deiner Retoure das Retourenportal auf kilagoo.com",
                "und gib dort deine Bestellnummer und die bei der Bestellung verwendete Mailadresse an.",
                "Liebe Grüße"
            };


        public static readonly string[,] ReturnItems = {
            

            {"1", "CLASSIC PREMIUM", "2475", "NAVY / GOLD", "M","","","",""},
            // {"2", "CLASSIC PREMIUM", "2475", "NAVY / GOLD", "M","","","",""},

            // {"3", "CLASSIC PREMIUM", "2475", "NAVY / GOLD", "M","","","",""},

            // {"4", "CLASSIC PREMIUM", "2475", "NAVY / GOLD", "M","","","",""},

            // {"5", "CLASSIC PREMIUM", "2475", "NAVY / GOLD", "M","","","",""},

            // {"6", "CLASSIC PREMIUM", "2475", "NAVY / GOLD", "M","","","",""},

            // {"7", "CLASSIC PREMIUM", "2475", "NAVY / GOLD", "M","","","",""},

            // {"8", "CLASSIC PREMIUM", "2475", "NAVY / GOLD", "M","","","",""},

            // {"9", "CLASSIC PREMIUM", "2475", "NAVY / GOLD", "M","","","",""},

            // {"10", "CLASSIC PREMIUM", "2475", "NAVY / GOLD", "M","","","",""},

            // {"11", "CLASSIC PREMIUM", "2475", "NAVY / GOLD", "M","","","",""},

            // {"12", "CLASSIC PREMIUM", "2475", "NAVY / GOLD", "M","","","",""},

            // {"13", "CLASSIC PREMIUM", "2475", "NAVY / GOLD", "M","","","",""},

            // {"14", "CLASSIC PREMIUM", "2475", "NAVY / GOLD", "M","","","",""},
            // {"15", "CLASSIC PREMIUM Shoes", "2475", "NAVY / GOLD", "M","","","",""},
            // {"16", "CLASSIC PREMIUM", "2475", "NAVY / GOLD", "M","","","",""},
            // {"17", "CLASSIC PREMIUM", "2475", "NAVY / GOLD", "M","","","",""},
            // {"18", "CLASSIC PREMIUM", "2475", "NAVY / GOLD", "M","","","",""},

            // {"19", "CLASSIC PREMIUM", "2475", "NAVY / GOLD", "M","","","",""},

            // {"20", "CLASSIC PREMIUM", "2475", "NAVY / GOLD", "M","","","",""},

            // {"21", "CLASSIC PREMIUM", "2475", "NAVY / GOLD", "M","","","",""},

            // {"22", "CLASSIC PREMIUM", "2475", "NAVY / GOLD", "M","","","",""},

            // {"23", "CLASSIC PREMIUM", "2475", "NAVY / GOLD", "M","","","",""},

            // {"24", "CLASSIC PREMIUM", "2475", "NAVY / GOLD", "M","","","",""},

            // {"25", "CLASSIC PREMIUM", "2475", "NAVY / GOLD", "M","","","",""},

            // {"26", "CLASSIC PREMIUM", "2475", "NAVY / GOLD", "M","","","",""},

            // {"27", "CLASSIC PREMIUM", "2475", "NAVY / GOLD", "M","","","",""},

            // {"28", "CLASSIC PREMIUM", "2475", "NAVY / GOLD", "M","","","",""},

            // {"29", "CLASSIC PREMIUM", "2475", "NAVY / GOLD", "M","","","",""},

            // {"30", "CLASSIC PREMIUM", "2475", "NAVY / GOLD", "M","","","",""},
            // {"31", "CLASSIC PREMIUM Shoes", "2475", "NAVY / GOLD", "M","","","",""},
            // {"32", "CLASSIC PREMIUM", "2475", "NAVY / GOLD", "M","","","",""},

            };
        public static readonly string[,] OrderItems =
{
    { "1", "100-234567", "Summer Dress", "Lightweight Cotton Dress | Size: M | Color: Floral", "1", "50,00 €", "50,00 €" },
    // { "2", "200-345678", "Running Shoes", "Men's Running Shoes | Size: 42.0 | Color: Blue", "2", "75,00 €", "150,00 €" },
    // { "3", "300-456789", "Evening Gown", "Elegant Silk Evening Gown | Size: L | Color: Red", "1", "200,00 €", "200,00 €" },
    // { "4", "400-567890", "Casual Sneakers", "Women's Casual Sneakers | Size: 38.0 | Color: White", "1", "60,00 €", "60,00 €" },
    // { "5", "500-678901", "Beach Dress", "Comfortable Beach Dress | Size: S | Color: Blue Stripes", "2", "40,00 €", "80,00 €" },
    // { "6", "600-789012", "Formal Shoes", "Leather Formal Shoes | Size: 43.0 | Color: Black", "1", "120,00 €", "120,00 €" },
    // { "7", "700-890123", "Cocktail Dress", "Chic Cocktail Dress | Size: M | Color: Black", "1", "85,00 €", "85,00 €" },
    // { "8", "800-901234", "Boots", "Winter Boots | Size: 39.0 | Color: Brown", "1", "95,00 €", "95,00 €" },
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
    // { "20", "200-123456", "Maxi Dress", "Flowy Maxi Dress | Size: L | Color: Green", "1", "65,00 €", "65,00 €" },
    // { "21", "300-234567", "Summer Dress", "Lightweight Cotton Dress | Size: M | Color: Floral", "1", "50,00 €", "50,00 €" },
    // { "22", "400-345678", "Running Shoes", "Men's Running Shoes | Size: 42.0 | Color: Blue", "2", "75,00 €", "150,00 €" },
    // { "23", "500-456789", "Evening Gown", "Elegant Silk Evening Gown | Size: L | Color: Red", "1", "200,00 €", "200,00 €" },
    // { "24", "600-567890", "Casual Sneakers", "Women's Casual Sneakers | Size: 38.0 | Color: White", "1", "60,00 €", "60,00 €" },
    // { "25", "700-678901", "Beach Dress", "Comfortable Beach Dress | Size: S | Color: Blue Stripes", "2", "40,00 €", "80,00 €" },
    // { "26", "800-789012", "Formal Shoes", "Leather Formal Shoes | Size: 43.0 | Color: Black", "1", "120,00 €", "120,00 €" },
    // { "27", "900-890123", "Cocktail Dress", "Chic Cocktail Dress | Size: M | Color: Black", "1", "85,00 €", "85,00 €" },
    // { "28", "100-901234", "Boots", "Winter Boots | Size: 39.0 | Color: Brown", "1", "95,00 €", "95,00 €" },
    // { "29", "200-012345", "Summer Sandals", "Comfortable Summer Sandals | Size: 37.0 | Color: Tan", "3", "30,00 €", "90,00 €" },
    // { "30", "300-123456", "Maxi Dress", "Flowy Maxi Dress | Size: L | Color: Green", "1", "65,00 €", "65,00 €" },
    // { "31", "400-234567", "Summer Dress", "Lightweight Cotton Dress | Size: M | Color: Floral", "1", "50,00 €", "50,00 €" },
    // { "32", "500-345678", "Running Shoes", "Men's Running Shoes | Size: 42.0 | Color: Blue", "2", "75,00 €", "150,00 €" },
    // { "33", "600-456789", "Evening Gown", "Elegant Silk Evening Gown | Size: L | Color: Red", "1", "200,00 €", "200,00 €" },
    // { "34", "700-567890", "Casual Sneakers", "Women's Casual Sneakers | Size: 38.0 | Color: White", "1", "60,00 €", "60,00 €" },
    // { "35", "800-678901", "Beach Dress", "Comfortable Beach Dress | Size: S | Color: Blue Stripes", "2", "40,00 €", "80,00 €" },
    // { "36", "900-789012", "Formal Shoes", "Leather Formal Shoes | Size: 43.0 | Color: Black", "1", "120,00 €", "120,00 €" },
    // { "37", "100-890123", "Cocktail Dress", "Chic Cocktail Dress | Size: M | Color: Black", "1", "85,00 €", "85,00 €" },
    // { "38", "200-901234", "Boots", "Winter Boots | Size: 39.0 | Color: Brown", "1", "95,00 €", "95,00 €" },
    // { "39", "300-012345", "Summer Sandals", "Comfortable Summer Sandals | Size: 37.0 | Color: Tan", "3", "30,00 €", "90,00 €" },
    // { "40", "400-123456", "Maxi Dress", "Flowy Maxi Dress | Size: L | Color: Green", "1", "65,00 €", "65,00 €" },
    // { "41", "500-234567", "Summer Dress", "Lightweight Cotton Dress | Size: M | Color: Floral", "1", "50,00 €", "50,00 €" },
    // { "42", "600-345678", "Running Shoes", "Men's Running Shoes | Size: 42.0 | Color: Blue", "2", "75,00 €", "150,00 €" },
    // { "43", "700-456789", "Evening Gown", "Elegant Silk Evening Gown | Size: L | Color: Red", "1", "200,00 €", "200,00 €" },
    // { "44", "400-567890", "Casual Sneakers", "Women's Casual Sneakers | Size: 38.0 | Color: White", "1", "60,00 €", "60,00 €" },
    // { "45", "500-678901", "Beach Dress", "Comfortable Beach Dress | Size: S | Color: Blue Stripes", "2", "40,00 €", "80,00 €" },
    // { "46", "600-789012", "Formal Shoes", "Leather Formal Shoes | Size: 43.0 | Color: Black", "1", "120,00 €", "120,00 €" },
    // { "47", "700-890123", "Cocktail Dress", "Chic Cocktail Dress | Size: M | Color: Black", "1", "85,00 €", "85,00 €" },
    // { "48", "800-901234", "Boots", "Winter Boots | Size: 39.0 | Color: Brown", "1", "95,00 €", "95,00 €" },
    // { "49", "900-012345", "Summer Sandals", "Comfortable Summer Sandals | Size: 37.0 | Color: Tan", "3", "30,00 €", "90,00 €" },
    // { "50", "100-123456", "Maxi Dress", "Flowy Maxi Dress | Size: L | Color: Green", "1", "65,00 €", "65,00 €" },
    // { "51", "200-234567", "Summer Dress", "Lightweight Cotton Dress | Size: M | Color: Floral", "1", "50,00 €", "50,00 €" },
    // { "52", "300-345678", "Running Shoes", "Men's Running Shoes | Size: 42.0 | Color: Blue", "2", "75,00 €", "150,00 €" },
    // { "53", "400-456789", "Evening Gown", "Elegant Silk Evening Gown | Size: L | Color: Red", "1", "200,00 €", "200,00 €" },
    // { "54", "500-567890", "Casual Sneakers", "Women's Casual Sneakers | Size: 38.0 | Color: White", "1", "60,00 €", "60,00 €" },
    // { "55", "600-678901", "Beach Dress", "Comfortable Beach Dress | Size: S | Color: Blue Stripes", "2", "40,00 €", "80,00 €" },
    // { "56", "700-789012", "Formal Shoes", "Leather Formal Shoes | Size: 43.0 | Color: Black", "1", "120,00 €", "120,00 €" },
    // { "57", "800-890123", "Cocktail Dress", "Chic Cocktail Dress | Size: M | Color: Black", "1", "85,00 €", "85,00 €" },
    // { "58", "900-901234", "Boots", "Winter Boots | Size: 39.0 | Color: Brown", "1", "95,00 €", "95,00 €" },
    // { "59", "100-012345", "Summer Sandals", "Comfortable Summer Sandals | Size: 37.0 | Color: Tan", "3", "30,00 €", "90,00 €" },
    // { "60", "100-234567", "Summer Dress", "Lightweight Cotton Dress | Size: M | Color: Floral", "1", "50,00 €", "50,00 €" },
    // { "61", "200-345678", "Running Shoes", "Men's Running Shoes | Size: 42.0 | Color: Blue", "2", "75,00 €", "150,00 €" },
    // { "62", "300-456789", "Evening Gown", "Elegant Silk Evening Gown | Size: L | Color: Red", "1", "200,00 €", "200,00 €" },
    // { "63", "400-567890", "Casual Sneakers", "Women's Casual Sneakers | Size: 38.0 | Color: White", "1", "60,00 €", "60,00 €" },
    // { "64", "500-678901", "Beach Dress", "Comfortable Beach Dress | Size: S | Color: Blue Stripes", "2", "40,00 €", "80,00 €" },
    // { "65", "600-789012", "Formal Shoes", "Leather Formal Shoes | Size: 43.0 | Color: Black", "1", "120,00 €", "120,00 €" },
    // { "66", "700-890123", "Cocktail Dress", "Chic Cocktail Dress | Size: M | Color: Black", "1", "85,00 €", "85,00 €" },
    // { "67", "800-901234", "Boots", "Winter Boots | Size: 39.0 | Color: Brown", "1", "95,00 €", "95,00 €" },
    // { "68", "900-012345", "Summer Sandals", "Comfortable Summer Sandals | Size: 37.0 | Color: Tan", "3", "30,00 €", "90,00 €" },
    // { "69", "100-123456", "Maxi Dress", "Flowy Maxi Dress | Size: L | Color: Green", "1", "65,00 €", "65,00 €" },
    // { "70", "200-234567", "Summer Dress", "Lightweight Cotton Dress | Size: M | Color: Floral", "1", "50,00 €", "50,00 €" },
    // { "71", "300-345678", "Running Shoes", "Men's Running Shoes | Size: 42.0 | Color: Blue", "2", "75,00 €", "150,00 €" },
    // { "72", "400-456789", "Evening Gown", "Elegant Silk Evening Gown | Size: L | Color: Red", "1", "200,00 €", "200,00 €" },
    // { "73", "500-567890", "Casual Sneakers", "Women's Casual Sneakers | Size: 38.0 | Color: White", "1", "60,00 €", "60,00 €" },
    // { "74", "600-678901", "Beach Dress", "Comfortable Beach Dress | Size: S | Color: Blue Stripes", "2", "40,00 €", "80,00 €" },
    // { "75", "700-789012", "Formal Shoes", "Leather Formal Shoes | Size: 43.0 | Color: Black", "1", "120,00 €", "120,00 €" },
    // { "76", "800-890123", "Cocktail Dress", "Chic Cocktail Dress | Size: M | Color: Black", "1", "85,00 €", "85,00 €" },
    // { "77", "900-901234", "Boots", "Winter Boots | Size: 39.0 | Color: Brown", "1", "95,00 €", "95,00 €" },
    // { "78", "100-012345", "Summer Sandals", "Comfortable Summer Sandals | Size: 37.0 | Color: Tan", "3", "30,00 €", "90,00 €" },
    // { "79", "200-123456", "Maxi Dress", "Flowy Maxi Dress | Size: L | Color: Green", "1", "65,00 €", "65,00 €" },
    // { "80", "300-234567", "Summer Dress", "Lightweight Cotton Dress | Size: M | Color: Floral", "1", "50,00 €", "50,00 €" },
    // { "81", "400-345678", "Running Shoes", "Men's Running Shoes | Size: 42.0 | Color: Blue", "2", "75,00 €", "150,00 €" },
    // { "82", "500-456789", "Evening Gown", "Elegant Silk Evening Gown | Size: L | Color: Red", "1", "200,00 €", "200,00 €" },
    // { "83", "600-567890", "Casual Sneakers", "Women's Casual Sneakers | Size: 38.0 | Color: White", "1", "60,00 €", "60,00 €" },
    // { "84", "700-678901", "Beach Dress", "Comfortable Beach Dress | Size: S | Color: Blue Stripes", "2", "40,00 €", "80,00 €" },
    // { "85", "800-789012", "Formal Shoes", "Leather Formal Shoes | Size: 43.0 | Color: Black", "1", "120,00 €", "120,00 €" },
    // { "86", "900-890123", "Cocktail Dress", "Chic Cocktail Dress | Size: M | Color: Black", "1", "85,00 €", "85,00 €" },
    // { "87", "100-901234", "Boots", "Winter Boots | Size: 39.0 | Color: Brown", "1", "95,00 €", "95,00 €" },
    // { "88", "200-012345", "Summer Sandals", "Comfortable Summer Sandals | Size: 37.0 | Color: Tan", "3", "30,00 €", "90,00 €" },
    // { "89", "300-123456", "Maxi Dress", "Flowy Maxi Dress | Size: L | Color: Green", "1", "65,00 €", "65,00 €" },
    // { "90", "400-234567", "Summer Dress", "Lightweight Cotton Dress | Size: M | Color: Floral", "1", "50,00 €", "50,00 €" },
    // { "91", "500-345678", "Running Shoes", "Men's Running Shoes | Size: 42.0 | Color: Blue", "2", "75,00 €", "150,00 €" },
    // { "92", "600-456789", "Evening Gown", "Elegant Silk Evening Gown | Size: L | Color: Red", "1", "200,00 €", "200,00 €" },
    // { "93", "700-567890", "Casual Sneakers", "Women's Casual Sneakers | Size: 38.0 | Color: White", "1", "60,00 €", "60,00 €" },
    // { "94", "800-678901", "Beach Dress", "Comfortable Beach Dress | Size: S | Color: Blue Stripes", "2", "40,00 €", "80,00 €" },
    // { "95", "900-789012", "Formal Shoes", "Leather Formal Shoes | Size: 43.0 | Color: Black", "1", "120,00 €", "120,00 €" },
    // { "96", "100-890123", "Cocktail Dress", "Chic Cocktail Dress | Size: M | Color: Black", "1", "85,00 €", "85,00 €" },
    // { "97", "200-901234", "Boots", "Winter Boots | Size: 39.0 | Color: Brown", "1", "95,00 €", "95,00 €" },
    // { "98", "300-012345", "Summer Sandals", "Comfortable Summer Sandals | Size: 37.0 | Color: Tan", "3", "30,00 €", "90,00 €" },
    // { "99", "400-123456", "Maxi Dress", "Flowy Maxi Dress | Size: L | Color: Green", "1", "65,00 €", "65,00 €" },
    // { "100", "500-234567", "Summer Dress", "Lightweight Cotton Dress | Size: M | Color: Floral", "1", "50,00 €", "50,00 €" },
    };

    }
}
