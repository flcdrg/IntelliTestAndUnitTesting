using Shouldly;


namespace IntelliTestAndUnitTesting.Fixie
{
    // Run with Test Explorer
    public class CalculatorTests
    {
        public void ShouldAdd()
        {
            var calculator = new Calculator();
            calculator.Add(2, 3).ShouldBe(5);
        }

        public void ShouldSubtract()
        {
            var calculator = new Calculator();
            calculator.Subtract(5, 3).ShouldBe(2);
        }


        #region Parameterised Tests

/*
        [Input(2, 3, 5)]
        [Input(3, 5, 8)]
        public void ShouldAdd2(int a, int b, int expectedSum)
        {
            var calculator = new Calculator();
            calculator.Add(a, b).ShouldBe(expectedSum);
        }

        [Input(5, 3, 2)]
        [Input(8, 5, 3)]
        [Input(10, 5, 5)]
        public void ShouldSubtract2(int a, int b, int expectedDifference)
        {
            var calculator = new Calculator();
            calculator.Subtract(a, b).ShouldBe(expectedDifference);
        }

*/
        #endregion
    }
}