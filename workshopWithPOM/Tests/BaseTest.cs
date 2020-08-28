using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using workshopWithPOM.Driver;

namespace workshopWithPOM.Tests
{
    public class BaseTest : IDisposable
    {

        public BaseTest(string url)
        {
            this.Driver.Navigate().GoToUrl(url);

        }

        private IWebDriver Driver 
        {
            get 
            {
                return DriverFactory.Driver;
            }
        }

        public void Dispose()
        {
            DriverFactory.Dispose();
        }


    }
}
