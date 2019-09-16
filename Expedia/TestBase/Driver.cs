using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Expedia.CommonUtilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Expedia.TestBase
{
    class Driver
    {
        CommonFunctionalities Common;
        public static IWebDriver driver;
 
        public void invoke_Driver()
        {
            Common = new CommonFunctionalities();
            driver = new ChromeDriver();
            Common.Maximize();
        }
        public void close_Driver()
        {
            driver.Close();
        }
    }
}
