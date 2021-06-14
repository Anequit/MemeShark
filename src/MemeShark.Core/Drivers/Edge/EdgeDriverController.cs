using MemeShark.Core.Common;
using OpenQA.Selenium;

namespace MemeShark.Core.Drivers.Edge
{
    public class EdgeDriverController : IDriverController
    {
        private readonly EdgeDriverFactory _factory;
        private IWebDriver _driver;
        private bool _running = false;
        
        public EdgeDriverController()
        {
            _factory = new EdgeDriverFactory();
        }

        public bool IsDriverPresent => _factory.CheckForDriverPresence();
        public bool IsDriverRunning => _running;
        public IWebDriver Driver => _driver;

        public void Run()
        {
            if (_running == true)
                _driver.Quit();

            _driver = _factory.Create();
            _running = true;
        }

        public void Stop()
        {
            if (!_running)
                return;

            _driver.Quit();
            _running = false;
        }
    }
}