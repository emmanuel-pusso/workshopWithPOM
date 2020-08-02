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
        private CareerPage page;

        public CareerTests()
        {
            page = new CareerPage();
            page.GoToUrl("https://careers.hexacta.com/");
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
                page.Driver.Close();
                page.Driver.Quit();
            }

            finally
            {
                page.Driver = null;
            }
        }
    }
}
