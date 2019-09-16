using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Expedia.TestBase;
using OpenQA.Selenium;

namespace Expedia.PageLogic
{
    class FlightReviewAndSelection : Driver
    {
        public IWebElement get_departure1()
        {
            return driver.FindElement(By.Id("departure-airport-1"));
        }

        public IWebElement get_arrival1()
        {
            return driver.FindElement(By.Id("arrival-airport-1"));
        }

        public IWebElement get_departure2()
        {
            return driver.FindElement(By.Id("departure-airport-2"));
        }

        public IWebElement get_arrival2()
        {
            return driver.FindElement(By.Id("arrival-airport-2"));
        }

        public IWebElement get_departure3()
        {
            return driver.FindElement(By.Id("departure-airport-3"));
        }

        public IWebElement get_arrival3()
        {
            return driver.FindElement(By.Id("arrival-airport-3"));
        }

        public IWebElement slect_fligh1()
        {
            return driver.FindElement(By.XPath("(//div[@class='grid-container standard-padding ']//button)[1]"));
        }

        public IWebElement slect_fligh2()
        {
            return driver.FindElement(By.XPath("(//div[@class='grid-container standard-padding ']//button)[1]"));
        }

        public IWebElement slect_fligh3()
        {
            return driver.FindElement(By.XPath("(//div[@class='grid-container standard-padding ']//button)[1]"));
        }

        public IWebElement get_totalFare()
        {
            return driver.FindElement(By.XPath("(//div//span[@class = 'tripTotalPrice hidden'])[1]"));
        }
    }
}
