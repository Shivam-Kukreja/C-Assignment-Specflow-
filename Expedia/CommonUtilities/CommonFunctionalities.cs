using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Expedia.TestBase;
using OpenQA.Selenium;

namespace Expedia.CommonUtilities
{
    class CommonFunctionalities: Driver
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
        public void send_keys(IWebElement element, string key)
        {
            element.SendKeys(key);
        }
        public void quit()
        {
            driver.Quit();
        }

        public String get_text(IWebElement element)
        {
            return element.Text;
        }

        public void wait()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }

        public void switchwindow()
        {
            driver.SwitchTo().Window(windowHandle());
        }

        public void SwitchTabs()
        {
            ArrayList tabs = new ArrayList(driver.WindowHandles);
            driver.SwitchTo().Window((String)tabs[1]);

        }

        public String windowHandle()
        {
            return driver.WindowHandles[0];
        }

        public double getFare(IWebElement e)
        {

            String totalText = e.GetAttribute("innerHTML");
            String[] Price = totalText.Split('$');
            return double.Parse(Price[1]);
        }

        public double getFare1(IWebElement e)
        {
            return double.Parse(e.GetAttribute("data-exact-price"));
        }
    }
}

