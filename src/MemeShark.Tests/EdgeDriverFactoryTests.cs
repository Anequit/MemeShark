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
    }
}
