using MemeShark.Core.Common;
using OpenQA.Selenium;

namespace MemeShark.Core.Drivers.Edge
{
    public class EdgeDriverController : IDriverController
    {
        private EdgeDriverFactory _factory;
        private IWebDriver _driver;

        public EdgeDriverController()
        {
            _factory = new EdgeDriverFactory();
        }

        public bool IsDriverPresent => _factory.CheckForDriverPresence();

        public void Run() => _driver = _factory.Create();
        public void Stop() => _driver.Close();
    }
}