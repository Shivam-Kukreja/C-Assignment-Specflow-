using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment.TestBase;
using OpenQA.Selenium;

namespace Assignment.CommonUtilities
{
    class CommonFunctionalities : Driver
    {
        public void Maximize()
        {
            driver.Manage().Window.Maximize();
        }

        public void go_to(String web)
        {
            driver.Url = web;
            driver.Navigate();
        }

        public bool check_title(String title)
        {
            return title.Equals(driver.Title);
        }
        public void press(IWebElement element)
        {
            element.Click();
        }
        public void send_keys(IWebElement element,string key)
        {
            element.SendKeys(key);
        }
        public String get_msg(IWebElement element)
        {
            return element.Text;
        }
        public void quit()
        {
            driver.Close();
        }
    }
}
