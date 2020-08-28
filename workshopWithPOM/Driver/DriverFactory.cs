using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workshopWithPOM.Driver
{
    // La idea de esta clase es setear el Browser para todos los tests. Ahora no tiene mucho sentido, todos corren sobre ChromeDriver, 
    // pero podría tener una instancia de FirefoxDriver, InternetExplorerDriver. Y desde acá seteo el Browser.
    public static class DriverFactory
    {
        private static IWebDriver driver;

        public static IWebDriver Driver
        {
            get
            {
                if (driver == null)
                {
                    ChromeOptions options = new ChromeOptions();
                    options.AddArguments(
                        "start-maximized",
                        "disable-infobars",
                        "disable-extensions"
                        );
                    driver = new ChromeDriver(options);
                    driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
                    driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(30);
                    driver.Manage().Timeouts().AsynchronousJavaScript = TimeSpan.FromSeconds(5);
                }

                return driver;
            }

        }

        public static void Dispose()
        {
            try
            {
                Driver.Close();
                Driver.Quit();
            }

            finally
            {
                driver = null;
            }
        }


    }
}
