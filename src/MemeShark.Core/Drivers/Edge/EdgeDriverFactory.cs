using MemeShark.Core.Common;
using OpenQA.Selenium;
using Microsoft.Edge.SeleniumTools;

namespace MemeShark.Core.Drivers.Edge
{
    public class EdgeDriverFactory : IDriver
    {
        public string Name { get; } = "MicrosoftWebDriver";
        public string Directory { get; } = $"./Drivers/";

        private EdgeOptions _options;
        private EdgeDriverService _service;

        public EdgeDriverFactory()
        {
            _options = ConfigureOptions();
            _service = ConfigureService();
        }

        public void Run()
        {
            EdgeDriver driver = new EdgeDriver(_service, _options);
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
                PageLoadStrategy = PageLoadStrategy.Normal,
                UseChromium = true,
                StartPage = "https://instagram.com"
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