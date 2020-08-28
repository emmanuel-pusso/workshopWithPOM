using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workshopWithPOM.Controls
{
    public class Link : BaseControl
    {
        public Link(By by) : base(by)
        {
        }

        public void Click() 
        {
            this.WebElement.Click();
        }

        public string Text 
        {
            get 
            {
                return this.WebElement.Text;
            }
                
        }

    }
}
