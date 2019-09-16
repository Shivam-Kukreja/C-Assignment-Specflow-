using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment.TestBase;
using OpenQA.Selenium;

namespace Assignment.Pages
{
    class Sign_inPL : Driver
    {
        public IWebElement Get_Signin_Btn()
        {
            return driver.FindElement(By.XPath("//a[contains(@title,'Log in ')]"));
        }
        public IWebElement Email_Input()
        {
            return driver.FindElement(By.XPath("//input[@id='email']"));
        }
        public IWebElement Password_Input()
        {
            return driver.FindElement(By.XPath("//input[@id='passwd']"));
        }
        public IWebElement SignIn_Button()
        {
            return driver.FindElement(By.XPath("//button[@name='SubmitLogin']"));
        }
        public IWebElement Errormessage_Field()
        {
            return driver.FindElement(By.XPath("//div[@class='alert alert-danger']//ol//li "));
        }
    }
}
