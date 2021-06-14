using Xunit;
using MemeShark.Core.Drivers.Edge;

namespace MemeShark.Tests
{
    public class EdgeDriverFactoryTests
    {
        [Fact]
        public void CheckIfDriverNameIsCorrect()
        {
            // Arrange 
            string expected = "msedgedriver.exe";

            // Act
            string actual = new EdgeDriverFactory().Name;

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CheckIfOptionsAreNull()
        {
            // Arrange
            EdgeDriverFactory factory = new EdgeDriverFactory();

            // Act
            factory.ConfigureDriverOptions();

            // Assert
            Assert.NotNull(factory.Options);
        }

        // If this test fails then you need to place the microsoft edge driver in the bin folder of the test project.
        // Download it at https://developer.microsoft.com/en-us/microsoft-edge/tools/webdriver/ 
        [Fact] 
        public void CheckIfServiceIsNull()
        {
            // Arrange
            EdgeDriverFactory factory = new EdgeDriverFactory();

            // Act
            factory.ConfigureDriverService();

            // Assert
            Assert.NotNull(factory.Service);
        }
    }
}
