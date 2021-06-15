using MemeShark.Core.Common;
using Microsoft.Edge.SeleniumTools;
using OpenQA.Selenium;
using System.IO;

namespace MemeShark.Core.Drivers.Edge
{
    public class EdgeDriverFactory : IDriverFactory
    {
        private EdgeOptions _options;
        private EdgeDriverService _service;

        public EdgeDriverFactory()
        {
            ConfigureDriverOptions();
            ConfigureDriverService();
        }

        // DO NOT CHANGE DEFAULT NAME
        public string Name { get; } = "msedgedriver.exe";
        public string Directory { get; } = "./Drivers/";
        public EdgeOptions Options => _options;
        public EdgeDriverService Service => _service;

        public IWebDriver Create() => new EdgeDriver(_service, _options);

        public bool CheckForDriverPresence() => File.Exists(Directory + Name);

        public void ConfigureDriverOptions()
        {
            _options = new EdgeOptions()
            {
                UnhandledPromptBehavior = UnhandledPromptBehavior.Dismiss,
                PageLoadStrategy = PageLoadStrategy.Normal,
                UseChromium = true
            };
        }

        public void ConfigureDriverService()
        {
            _service = EdgeDriverService.CreateChromiumService(Directory, Name);
            _service.HideCommandPromptWindow = true;
        }
    }
}