using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace workshopWithPOM
{
    public class CareerTests : IDisposable
    {
        private CareerPage career;

        public CareerTests()
        {
            career = new CareerPage();
            career.GoToUrl("https://careers.hexacta.com/");
            career.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }

        [Fact]
        public void testOpenPageAndClickOnPlanCarreraLink()
        {
            career.clickPlanCarreraLink();
        }

        public void Dispose()
        {
            try
            {
                career.Driver.Close();
                career.Driver.Quit();
            }

            finally
            {
                career.Driver = null;
            }
        }
    }
}
