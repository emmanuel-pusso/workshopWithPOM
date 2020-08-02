using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workshopWithPOM
{
    class CareerPage : BasePage
    {
        private By planCarreraLink = By.XPath("//a[contains(text(),'Plan de Carrera')]");
        public CareerPage(String url): base(url) {}

        public CareerPage clickPlanCarreraLink() {
            this.FindElementWait(planCarreraLink).Click();
            return this;
        }




    }
}
