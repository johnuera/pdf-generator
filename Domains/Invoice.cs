using Newtonsoft.Json;

namespace PDFGenerator.Domains
{
    public class General
    {
        public int Client { get; set; }
        public string? Language { get; set; }
        public string? InvoiceHeadline { get; set; }
        public string? PackingListHeadline { get; set; }
        public string? ClientName { get; set; }
        public string? ClientCode { get; set; }

        public string? ClientStreet { get; set; }
        public string? ClientCity { get; set; }
        public string? ClientTel { get; set; }
        public string? ClientMail { get; set; }
        public string? ClientUrl { get; set; }
        public string? Service { get; set; }
    }

    public class OrderText
    {
        public string? CustomerNumber { get; set; }
        public string? Number { get; set; }
        public string? OrderNumber { get; set; }
        public string? Date { get; set; }
        public string? DeliveryAddress { get; set; }
        public string? InvoiceAddress { get; set; }
    }

    public class ArticleTable
    {
        public string? HeaderPos { get; set; }
        public string? HeaderNo { get; set; }
        public string? HeaderImage { get; set; }
        public string? HeaderDescription { get; set; }
        public string? HeaderColor { get; set; }
        public string? HeaderSize { get; set; }
        public string? HeaderQuantity { get; set; }
        public string? HeaderPrice { get; set; }
        public string? HeaderTotal { get; set; }
        public string? HeaderReasonForReturn { get; set; }
    }

    public class InvoiceDetails
    {
        public string? ValueOfGoods { get; set; }
        public string? ShippingCosts { get; set; }
        public string? PaymentCosts { get; set; }
        public string? GiftWrapCosts { get; set; }
        public string? Discount { get; set; }
        public string? DiscountName { get; set; }
        public string? Total { get; set; }
        public string? VAT { get; set; }
        public string? From { get; set; }
        public string? NetTotal { get; set; }
        public string? ThankYou { get; set; }
    }

    public class PaymentText
    {
        public string? Method { get; set; }
        public string? HintInvoice { get; set; }
        public string? HintCreditCard { get; set; }
        public string? HintPrepayment { get; set; }
        public string? HintPaypal { get; set; }
        public string? HintCOD { get; set; }
        public string? HintSofortueberweisung { get; set; }
        public string? HintPayOne { get; set; }
        public string? ReturnHint { get; set; }
        public string? ReturnText1 { get; set; }
        public string? ReturnText2 { get; set; }
        public string? Regards { get; set; }


    }

    public class ReturnText
    {
        public string? ReturnHeadline { get; set; }

        public string? ReceiptHeadline { get; set; }
        public string? ReceiptOrderNo { get; set; }
        public string? ReceiptOrderDate { get; set; }
        public string? Reasons { get; set; }
        public string? Reason1 { get; set; }
        public string? Reason2 { get; set; }
        public string? Reason3 { get; set; }
        public string? Reason4 { get; set; }
        public string? Reason5 { get; set; }
        public string? Reason6 { get; set; }
        public string? Reason7 { get; set; }
        public string? Reason8 { get; set; }
        public string? Reason9 { get; set; }
        public string? NoExchange { get; set; }
        public string? Hint1 { get; set; }
        public string? Hint2 { get; set; }
        public string? Hint3 { get; set; }
    }

    public class Footer
    {
        public string? Greeting { get; set; }
        public string? Signature { get; set; }
        public string[]?  Left { get; set; }
        public string[]?  Right { get; set; }
        public string[]?  Center { get; set; }

    }

    public class Root
    {
        public General? General { get; set; }
        public OrderText? OrderText { get; set; }
        public ArticleTable? ArticleTable { get; set; }
        public InvoiceDetails? InvoiceDetails { get; set; }
        public PaymentText? PaymentText { get; set; }
        public ReturnText? ReturnText { get; set; }
        public Footer? Footer { get; set; }
    }
    public class JsonReader
    {
        public static Root ReadJsonFromFile(string filePath)
        {
            // Read JSON string from file
            string json = File.ReadAllText(filePath);
            
            // Deserialize the JSON string into a Root object
            return JsonConvert.DeserializeObject<Root>(json);
        }
    }
}