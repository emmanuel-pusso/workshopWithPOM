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
            page = new CareerPage("https://careers.hexacta.com/");
        }

        public void Dispose()
        {
            page.Dispose();
        }

        [Fact]
        public void testOpenPageAndClickOnPlanCarreraLink()
        {
            page.clickPlanCarreraLink();
        }

        
    }
}
