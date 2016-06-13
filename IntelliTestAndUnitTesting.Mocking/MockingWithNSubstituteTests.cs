using System;
using NSubstitute;
using Xunit;

namespace IntelliTestAndUnitTesting.Mocking
{
    public class MockingWithNSubstituteTests
    {
        [Fact]
        public void Test()
        {
            // Arrange
            const int orderId = 481; // Order Date 2013-01-09
            var dataLayer = new DataLayer();
            var sut = new BusinessService(dataLayer);

            // Act
            var result = sut.CalculateShipping(orderId);

            // Assert
            Assert.Equal(11, result);
        }
    }
}
