using System;
using System.Collections.Generic;

namespace CodeProblemsInitialCommit
{
    public class OrderBuilder
    {
        Dictionary<string, object> customCreateOrderRequestValues = new Dictionary<string, object>();

        public void SetCustomCreateOrderRequestValue(string key, string value)
        {
            customCreateOrderRequestValues.Add(key, value);
        }

        public CreateOrderRequest BuildCreateOrderRequest()
        {
            var newCreateOrderRequest = new CreateOrderRequest();

            newCreateOrderRequest.Items = BuildOrderRequestItems();
            //if (customCreateOrderRequestValues.ContainsKey("Items"))

            newCreateOrderRequest.ShippingInformation = BuildCreateOrderRequestShippingInformation();
            if (customCreateOrderRequestValues.ContainsKey("ShippingAddress.City"))
                newCreateOrderRequest.ShippingInformation.ShippingAddress.RecipientName = customCreateOrderRequestValues["ShippingAddress.City"].ToString();

            return newCreateOrderRequest;
        }

        private ShippingInformation BuildCreateOrderRequestShippingInformation(string recipientName = "cb", string address1 = "address line 1", string city = "Salt Lake City")
        {
            var newShippingInformation = new ShippingInformation
            {
                ShippingAddress = new Address()
            };
            return newShippingInformation;
        }

        private List<Item> BuildOrderRequestItems( string upc = "123", int quantity = 1, decimal itemPrice = 1, decimal taxRate = 7, decimal totalTax = 0 ) //, List<Discount> discounts = new List<Discount>() )
        {
            var items = new List<Item>();
            return items;
        }
    }
}
