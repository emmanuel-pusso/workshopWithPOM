using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using workshopWithPOM.Driver;

namespace workshopWithPOM.Controls
{
    public class BaseControl
        
    {
        protected By by;
        protected IWebDriver driver = DriverFactory.Driver;

        public BaseControl(By by)
        {
            this.by = by;
        }

        protected IWebElement WebElement
        {
            get
            {
              return this.driver.FindElement(this.by);
            }
                
        }

    }
}
