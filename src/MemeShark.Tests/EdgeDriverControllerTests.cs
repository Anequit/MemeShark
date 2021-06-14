using MemeShark.Core.Drivers.Edge;
using Xunit;

namespace MemeShark.Tests
{
    public class EdgeDriverControllerTests
    {
        readonly EdgeDriverController controller = new EdgeDriverController();

        [Fact]
        public void CheckIfDriverRuns()
        {
            // Arrange 
            bool expected = true;

            // Act
            controller.Run();
            bool actual = controller.IsDriverRunning;
            controller.Stop();

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CheckIfDriverStops()
        {
            // Arrange
            bool expected = false;

            // Act
            controller.Run();
            controller.Stop();
            bool actual = controller.IsDriverRunning;

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
