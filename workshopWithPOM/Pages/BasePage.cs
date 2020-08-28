using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using workshopWithPOM.Driver;

namespace workshopWithPOM
{
    public class BasePage
    {
        //uso una property de C# para el driver
        public IWebDriver Driver { get; set; }

        private WebDriverWait waiter;
        private By by;

        public void SetUp() 
        {
            this.Driver = DriverFactory.Driver;
            waiter = new WebDriverWait(this.Driver, TimeSpan.FromSeconds(10));
        }
        public BasePage()
        {    
            this.SetUp();
        }

        public BasePage(String url)
        {
            this.SetUp();
            this.Driver.Url = url;
        }

        public BasePage( By by )
        {
            this.by = by;
            this.SetUp();
        }


        public IWebElement FindElementWait(By locator)
        {
            waiter.Until(x => this.Driver.FindElement(locator) != null);
            return this.Driver.FindElement(locator);
        }

        public IEnumerable<IWebElement> FindElementsWait(By locator)
        {
            waiter.Until(x => this.Driver.FindElements(locator).Count > 0);
            return this.Driver.FindElements(locator);
        }

        public void GoToUrl(String url)
        {
            this.Driver.Navigate().GoToUrl(url);
        }

    }
}




