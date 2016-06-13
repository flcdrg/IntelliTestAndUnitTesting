using System;

namespace IntelliTestAndUnitTesting.Mocking
{
    public class BusinessService
    {
        private readonly IDataLayer _dataLayer;
        private static readonly DateTime Date1 = new DateTime(2013, 1, 10);
        private static readonly DateTime Date2 = new DateTime(2013, 1, 17);

        public BusinessService(IDataLayer dataLayer)
        {
            _dataLayer = dataLayer;
        }

        public int CalculateShipping(int orderId)
        {
            Order order = _dataLayer.GetOrder(orderId);

            int shipping;
            if (order.OrderDate <= Date1)
                shipping = 10;
            else if (order.OrderDate <= Date2)
                shipping = 15;
            else
                shipping = 30;

            // tax inclusive
            shipping += (int) (shipping*0.1);

            return shipping;
        }
    }
}