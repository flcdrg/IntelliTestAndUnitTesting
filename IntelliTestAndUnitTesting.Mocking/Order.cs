using System;

namespace IntelliTestAndUnitTesting.Mocking
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime ExpectedDeliveryDate { get; set; }
        public bool IsUndersupplyBackordered { get; set; }
    }
}