using Xunit;

namespace IntelliTestAndUnitTesting.Mocking
{
    public class MockingWithNSubstituteTests
    {
        [Fact]
        public void Test()
        {
            // Arrange
            const int orderId = 3;
            var dataLayer = new DataLayer();
            var sut = new BusinessService(dataLayer);

            // Act
            var result = sut.CalculateShipping(orderId);

            // Assert
            Assert.Equal(33, result);
        }
    }
}
