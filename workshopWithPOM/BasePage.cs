using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workshopWithPOM
{
    public class BasePage
    {
        //private ChromeDriver Driver;
        public ChromeDriver Driver { get; set; }

        private WebDriverWait waiter;

        public BasePage()
        {
            this.Driver = new ChromeDriver();
            this.Driver.Manage().Window.Maximize();
            waiter = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
        }

        public IWebElement FindElementWait(By locator)
        {
            waiter.Until(x => this.Driver.FindElement(locator) != null);
            return Driver.FindElement(locator);
        }

        public ReadOnlyCollection<IWebElement> FindElementsWait(By locator)
        {
            return Driver.FindElements(locator);
        }

        public String Text(IWebElement element)
        {
            return element.Text;
        }
        public String Text(By locator)
        {
            return this.FindElementWait(locator).Text;
        }

        public void SendKey(String inputText, By locator)
        {
            this.FindElementWait(locator).SendKeys(inputText);
        }
        public void Click(By locator)
        {
            this.FindElementWait(locator).Click();
        }

        public Boolean Displayed(By locator)
        {
            try
            {
                return this.FindElementWait(locator).Displayed;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        public void GoToUrl(String url)
        {
            Driver.Navigate().GoToUrl(url);
        }

    }
}




