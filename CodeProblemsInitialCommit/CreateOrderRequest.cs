using System;
using System.Collections.Generic;

namespace CodeProblemsInitialCommit
{
    public class CreateOrderRequest
    {
        public List<Item> Items { get; set; }
        public ShippingInformation ShippingInformation { get; set; }
    }

    public class Item
    {
        public string Upc { get; set; }
        public int Quantity { get; set; }
        public decimal ItemPrice { get; set; }
        public decimal TaxRate { get; set; }
        public decimal TotalTax { get; set; }
        public List<Discount> Discounts { get; set; }
    }

    public class Discount
    {
        public string DiscountCode { get; set; }
        public string SubCode { get; set; }
        public decimal Amount { get; set; }
    }


    public class ShippingInformation
    {
        public Address ShippingAddress { get; set; }
        public string ShippingPhone { get; set; }
        //public ShippingServiceLevelEnum ShippingServiceLevel { get; set; }
        public bool IsSignatureRequired { get; set; }
        public DateTime OriginalDeliveryQuoteDate { get; set; }
    }

    public class Address
    {
        public string RecipientName { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
    }
}
