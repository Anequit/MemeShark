using System;
using OpenQA.Selenium;

namespace MemeShark.Core.Chrome
{
    public class ChromeDriverController : IDriverController
    {
        public bool IsDriverPresent => throw new NotImplementedException();

        public bool IsDriverRunning => throw new NotImplementedException();

        public IWebDriver Driver => throw new NotImplementedException();

        public void Run()
        {
            throw new NotImplementedException();
        }

        public void Stop()
        {
            throw new NotImplementedException();
        }
    }
}
