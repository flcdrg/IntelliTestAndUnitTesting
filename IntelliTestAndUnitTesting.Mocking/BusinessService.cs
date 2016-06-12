namespace IntelliTestAndUnitTesting.Mocking
{
    public class BusinessService
    {
        private readonly IDataLayer _dataLayer;

        public BusinessService(IDataLayer dataLayer)
        {
            _dataLayer = dataLayer;
        }

        public int CalculateShipping(int orderId)
        {
            Order order = _dataLayer.GetOrder(orderId);

            int shipping;
            if (order.Address.Contains("Sydney"))
                shipping = 10;
            else if (order.Address.Contains("Adelaide"))
                shipping = 15;
            else
                shipping = 30;

            // tax inclusive
            shipping += (int) (shipping*0.1);

            return shipping;
        }
    }
}