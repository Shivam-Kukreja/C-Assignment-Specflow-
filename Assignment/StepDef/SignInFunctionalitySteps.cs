using System;
using Assignment.BusinessLogic;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace Assignment.StepDef
{
    [Binding]
    public class SignInFunctionalitySteps
    {
        static Sign_inBL obj;
        [Given(@"I am on the home page")]
        public void GivenIAmOnTheHomePage()
        {
            obj = new Sign_inBL();
            Assert.IsTrue(obj.check_HomePage());
        }
        
        [When(@"I clicks on SignIn button")]
        public void WhenIClicksOnSignInButton()
        {
            Assert.IsTrue(obj.Click_SignIn());
        }

        [When(@"I enters username as (.*) and password as (.*)")]
        public void WhenIEntersUsernameAsAndPasswordAs(string p0, string p1)
        {
            Assert.IsTrue(obj.keys(p0,p1));
        }

        [When(@"I click on SignIn button")]
        public void WhenIClickOnSignInButton()
        {
            Assert.IsTrue(obj.Login_Btn());
        }
        
        [Then(@"I should see (.*)")]
        public void ThenIShouldSee(string p0)
        {
            Assert.AreEqual(p0, obj.get_error());
            obj.close_browser();
        }
        

        

    }
}
