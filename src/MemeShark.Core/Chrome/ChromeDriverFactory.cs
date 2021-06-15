using System.IO;
using MemeShark.Core.Entities;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace MemeShark.Core.Chrome
{
    public class ChromeDriverFactory : IDriverFactory
    {
        private ChromeOptions _options;
        private ChromeDriverService _service;

        public ChromeDriverFactory()
        {
            ConfigureDriverOptions();
            ConfigureDriverService();
        }

        // DO NOT CHANGE DEFAULT NAME
        public string Name { get; } = DriverName.Chrome;
        public string Directory { get; } = "./Drivers/";
        public ChromeOptions Options => _options;
        public ChromeDriverService Service => _service;

        public IWebDriver Create() => new ChromeDriver(_service, _options);

        public bool CheckForDriverPresence() => File.Exists(Directory + Name);

        public void ConfigureDriverOptions()
        {
            _options = new ChromeOptions()
            {
                UnhandledPromptBehavior = UnhandledPromptBehavior.Dismiss,
                PageLoadStrategy = PageLoadStrategy.Normal
            };
        }

        public void ConfigureDriverService()
        {
            _service = ChromeDriverService.CreateDefaultService(Directory, Name);
            _service.HideCommandPromptWindow = true;
        } 
    }
}