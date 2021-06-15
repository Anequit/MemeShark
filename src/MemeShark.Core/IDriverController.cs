using OpenQA.Selenium;

namespace MemeShark.Core
{
    interface IDriverController
    {
        public bool IsDriverPresent { get; }
        public bool IsDriverRunning { get; }
        public IWebDriver Driver { get; }

        public void Run();
        public void Stop();
    }
}