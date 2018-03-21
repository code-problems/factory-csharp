using System;

namespace CodeProblemsInitialCommit
{

    class Program
    {
        static void Main(string[] args)
        {
            var orderBuilder = new OrderBuilder();

            orderBuilder.SetCustomCreateOrderRequestValue("ShippingAddress.City", "Draper");
            orderBuilder.BuildCreateOrderRequest();
        }
    }
}
