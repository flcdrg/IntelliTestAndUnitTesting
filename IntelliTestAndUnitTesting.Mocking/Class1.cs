using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntelliTestAndUnitTesting.Mocking
{
    public class MockingWithNSubstitute
    {
        public void Test()
        {
            // Arrange
            const int orderId = 3;
            var sut = new BusinessService(dataLayer);

            // Act
            var result = sut.CalculateShipping(orderId);

            // Assert
            Assert.AreEquals(33, result);
        }
    }
}
