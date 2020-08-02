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
    public class BasePage : IDisposable
    {
        //uso una property de C# para el driver
        public IWebDriver Driver { get; set; }

        private WebDriverWait waiter;

        public BasePage()
        {
            this.Driver = DriverFactory.GetBrowserDriver();
            waiter = new WebDriverWait(this.Driver, TimeSpan.FromSeconds(10));
        }

        public BasePage(IWebDriver driver)
        {
            this.Driver = driver;
            waiter = new WebDriverWait(this.Driver, TimeSpan.FromSeconds(10));
        }

        public BasePage(String url)
        {
            this.Driver = DriverFactory.GetBrowserDriver();
            this.Driver.Url = url;
            waiter = new WebDriverWait(this.Driver, TimeSpan.FromSeconds(10));
        }

        public IWebElement FindElementWait(By locator)
        {
            waiter.Until(x => this.Driver.FindElement(locator) != null);
            return this.Driver.FindElement(locator);
        }

        public ReadOnlyCollection<IWebElement> FindElementsWait(By locator)
        {
            return this.Driver.FindElements(locator);
        }

        public void GoToUrl(String url)
        {
            this.Driver.Navigate().GoToUrl(url);
            this.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }

        public void Dispose()
        {
            try
            {
                this.Driver.Close();
                this.Driver.Quit();
            }

            finally
            {
                this.Driver = null;
            }
        }

    }
}




