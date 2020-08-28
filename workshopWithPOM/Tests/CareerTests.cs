using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using workshopWithPOM.Tests;
using Xunit;

namespace workshopWithPOM
{
    public class CareerTests: BaseTest
    {
        private CareerPage page;

        public CareerTests():base("https://careers.hexacta.com/")
        {
            page = new CareerPage();
        }

       
        [Fact]
        public void testOpenPageAndClickOnPlanCarreraLink()
        {
            page.Link.Click(); //a la pagina le digo dame el objeto Link, y el objeto Link hace el click
        }

     

    }
}
