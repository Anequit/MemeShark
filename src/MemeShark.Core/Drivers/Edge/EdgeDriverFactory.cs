using MemeShark.Core.Common;
using Microsoft.Edge.SeleniumTools;
using OpenQA.Selenium;
using System.IO;

namespace MemeShark.Core.Drivers.Edge
{
    public class EdgeDriverFactory : IDriverFactory
    {
        // DO NOT CHANGE DEFAULT NAME
        public string Name { get; } = "msedgedriver.exe";
        public string Directory { get; } = "./Drivers/";
        public EdgeOptions Options => _options;
        public EdgeDriverService Service => _service;

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

        public void ConfigureDriverOptions()
        {
            _options = new EdgeOptions()
            {
                UnhandledPromptBehavior = UnhandledPromptBehavior.Dismiss,
                PageLoadStrategy = PageLoadStrategy.Normal,
                UseChromium = true,
                StartPage = "https://instagram.com"
            };
        }

        public void ConfigureDriverService()
        {
            _service = EdgeDriverService.CreateChromiumService(Directory, Name);
            _service.HideCommandPromptWindow = true;
        }
    }
}