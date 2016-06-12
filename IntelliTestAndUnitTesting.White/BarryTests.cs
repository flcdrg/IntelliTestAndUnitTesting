using TestStack.White;
using TestStack.White.Factory;
using TestStack.White.UIItems;
using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems.ListBoxItems;
using TestStack.White.UIItems.WindowItems;
using TestStack.White.WindowsAPI;
using Xunit;

namespace IntelliTestAndUnitTesting.White
{
    public class BarryTests
    {
        [Fact]
        public void ChoosingThreeFromList_EnablesButton()
        {
            // Arrange
            var applicationPath = @"..\..\..\IntelliTestAndUnitTesting.WhiteWpfApp\bin\Debug\IntelliTestAndUnitTesting.WhiteWpfApp.exe";
            Application application = Application.Launch(applicationPath);
            Window window = application.GetWindow("MainWindow", InitializeOption.NoCache);

            var button = window.Get<Button>(SearchCriteria.ByAutomationId("MyButton"));
            var list = window.Get<ComboBox>(SearchCriteria.ByAutomationId("MyList"));

            // Act
            list.KeyIn(KeyboardInput.SpecialKeys.DOWN);
            list.KeyIn(KeyboardInput.SpecialKeys.DOWN);

            // Assert
            Assert.True(button.Enabled);
        }
    }
}
