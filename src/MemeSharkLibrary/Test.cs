using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using Microsoft.Edge.SeleniumTools;

namespace MemeSharkLibrary
{
    public class Test
    {
        public Test()
        {
            Setup();
        }

        void Setup()
        {

            using (EdgeDriverService service = EdgeDriverService.CreateChromiumService())
            {
                service.HideCommandPromptWindow = true;

                EdgeOptions options = new();
                options.UseChromium = true;
                options.BinaryLocation = @"C:\Program Files (x86)\Microsoft\Edge\Application\msedge.exe";

                EdgeDriver driver = new(service, options);
            }
        }
    }
}
