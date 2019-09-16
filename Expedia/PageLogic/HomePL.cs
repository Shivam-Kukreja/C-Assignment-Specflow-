using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Expedia.TestBase;
using OpenQA.Selenium;

namespace Expedia.ObjectRepo
{
    class HomePL : Driver
    {
        public IWebElement Get_FLight_Btn()
        {
            return driver.FindElement(By.XPath("//button[@id='tab-flight-tab-hp']"));
        }

        public IWebElement Get_Multicity()
        {
            return driver.FindElement(By.XPath("//label[@id='flight-type-multi-dest-label-hp-flight']"));
        }

        public IWebElement FlyingFrom_Leg1()
        {
            return driver.FindElement(By.XPath("//input[@id='flight-origin-hp-flight']"));
        }

        public IWebElement FlyingTo_Leg1()
        {
            return driver.FindElement(By.XPath("//input[@id='flight-destination-hp-flight']"));
        }

        public IWebElement FlyingFrom_Leg2()
        {
            return driver.FindElement(By.XPath("//input[@id='flight-2-origin-hp-flight']"));
        }

        public IWebElement FlyingTo_Leg2()
        {
            return driver.FindElement(By.XPath("//input[@id='flight-2-destination-hp-flight']"));
        }

        public IWebElement FlyingFrom_Leg3()
        {
            return driver.FindElement(By.XPath("//input[@id='flight-3-origin-hp-flight']"));
        }

        public IWebElement FlyingTo_Leg3()
        {
            return driver.FindElement(By.XPath("//input[@id='flight-3-destination-hp-flight']"));
        }

        public IWebElement Get_Add_anotherlight()
        {
            return driver.FindElement(By.XPath("//a[@id='add-flight-leg-hp-flight']"));
        }

        public IWebElement flight1_date()
        {
            return driver.FindElement(By.XPath("//input[@id='flight-departing-single-hp-flight']"));
        }

        public IWebElement flight2_date()
        {
            return driver.FindElement(By.XPath("//input[@id='flight-2-departing-hp-flight']"));
        }

        public IWebElement flight3_date()
        {
            return driver.FindElement(By.XPath("//input[@id='flight-3-departing-hp-flight']"));
        }

        public IWebElement Search_btn()
        {
            return driver.FindElement(By.XPath("//form[@id = 'gcw-flights-form-hp-flight']//button[@type='submit']"));
        }

        public IWebElement get_pax()
        {
            return driver.FindElement(By.XPath("//*[@id='traveler-selector-hp-flight']//li/button"));
        }

        public IWebElement increase_pax()
        {
            return driver.FindElement(By.XPath("(//*[@class='uitk-icon-svg uitk-step-input-icon'])[2]"));
        }

    }
}
