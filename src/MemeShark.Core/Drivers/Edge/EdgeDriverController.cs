using MemeShark.Core.Common;
using OpenQA.Selenium;

namespace MemeShark.Core.Drivers.Edge
{
    public class EdgeDriverController : IDriverController
    {
        private readonly EdgeDriverFactory _factory;
        private IWebDriver _driver;
        
        public EdgeDriverController()
        {
            _factory = new EdgeDriverFactory();
        }

        public bool IsDriverPresent => _factory.CheckForDriverPresence();
        public bool IsDriverRunning => _factory.Service.IsRunning;
        public IWebDriver Driver => _driver;

        public void Run()
        {
            if (_factory.Service.IsRunning)
                _driver.Quit();

            _driver = _factory.Create();
        }

        public void Stop()
        {
            if (!_factory.Service.IsRunning)
                return;

            _driver.Quit();
        }
    }
}