using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using workshopWithPOM.Controls;

namespace workshopWithPOM
{
    public class CareerPage : BasePage
    {
     
        public CareerPage() : base(By.XPath("")) { }

        public Link Link
        {
            get
            {
                return new Link(By.XPath("//a[contains(text(),'Plan de Carrera')]"));
            }
        }


        // para locators, y metodos con varios pasos/acciones






    }
}
