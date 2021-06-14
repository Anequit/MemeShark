using MemeShark.Core.Common;
using Microsoft.Edge.SeleniumTools;
using OpenQA.Selenium;
using System.IO;

namespace MemeShark.Core.Drivers.Edge
{
    class EdgeDriverFactory : IDriverFactory
    {
        public string Name { get; } = "msedgedriver.exe";
        public string Directory { get; } = $"./Drivers/";

        private EdgeOptions _options;
        private EdgeDriverService _service;

        public IWebDriver Create() => ConfigureDriver();

        public bool CheckForDriverPresence() => File.Exists(Directory + Name);

        private IWebDriver ConfigureDriver()
        {
            ConfigureDriverOptions();
            ConfigureDriverService();

            return new EdgeDriver(_service, _options);
        }

        private void ConfigureDriverOptions()
        {
            _options = new EdgeOptions()
            {
                UnhandledPromptBehavior = UnhandledPromptBehavior.Dismiss,
                PageLoadStrategy = PageLoadStrategy.Normal,
                UseChromium = true,
                StartPage = "https://instagram.com"
            };
        }

        private void ConfigureDriverService()
        {
            _service = EdgeDriverService.CreateChromiumService();
            _service = EdgeDriverService.CreateDefaultService();
            _service.HideCommandPromptWindow = true;
        }
    }
}