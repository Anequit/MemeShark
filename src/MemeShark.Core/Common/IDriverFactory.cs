using OpenQA.Selenium;

namespace MemeShark.Core.Common
{
    interface IDriverFactory
    {
        public string Name { get; }
        public string Directory { get; }

        public IWebDriver Create();
        public bool CheckForDriverPresence();
        public void ConfigureDriverOptions();
        public void ConfigureDriverService();
    }
}