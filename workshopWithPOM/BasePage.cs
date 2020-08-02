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
    public class BasePage : IDisposable
    {
        private ChromeDriver driver;
        private WebDriverWait waiter;

        public BasePage()
        {
            this.driver = new ChromeDriver();
            this.driver.Manage().Window.Maximize();
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        }

        public IWebElement FindElementWait(By locator)
        {
            this.waiter.Until(x => this.driver.FindElement(locator) != null);
            return driver.FindElement(locator);
        }

        public ReadOnlyCollection<IWebElement> FindElementsWait(By locator)
        {
            return driver.FindElements(locator);
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

        public void GoToUrl (String url)
        {
            driver.Navigate().GoToUrl(url);
        }

        public void Dispose()
        {
            try
            {
                this.driver.Close();
                this.driver.Quit();
            }

            finally
            {
                this.driver = null;
            }

        }
    }
}




