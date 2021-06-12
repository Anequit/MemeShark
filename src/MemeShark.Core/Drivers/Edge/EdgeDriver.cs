using MemeShark.Core.Common;
using OpenQA.Selenium;
using OpenQA.Selenium.Edge;

namespace MemeShark.Core.Drivers.Edge
{
    class EdgeDriver : IDriver
    {
        public string Name { get; } = "";
        public string Directory { get; } = "";

        private EdgeOptions _options;
        private EdgeDriverService _service;

        public EdgeDriver()
        {
            _options = ConfigureOptions();
            _service = ConfigureService();
        }

        public void Run()
        {
            throw new System.NotImplementedException();
        }

        public bool CheckForDriver()
        {
            /* if driver is present
             *  return true
             * 
             * if driver isn't present
             *  return false
             */
            throw new System.NotImplementedException();
        }

        private EdgeOptions ConfigureOptions()
        {
            EdgeOptions options = new EdgeOptions()
            {
                UnhandledPromptBehavior = UnhandledPromptBehavior.Dismiss,
                PageLoadStrategy = PageLoadStrategy.Normal
            };

            return options;
        }

        private EdgeDriverService ConfigureService()
        {
            EdgeDriverService service = EdgeDriverService.CreateDefaultService();
            service.HideCommandPromptWindow = true;

            return service;
        }

    }
}