using System;
using NUnit.Framework;
using ReqRes.Business_Logic;
using TechTalk.SpecFlow;

namespace ReqRes.Step_Def
{
    [Binding]
    public class ReqResAPITestsSteps
    {
         ScenarioLogic func;
        [When(@"I register a new user with credentials (.*) and (.*)")]
        public void WhenIRegisterANewUserWithCredentialsAnd(string p0, string p1)
        {
            func = new ScenarioLogic();
            func.invoke();
            func.Registration(p0, p1);
        }
        
        [When(@"user send a GET request")]
        public void WhenUserSendAGETRequest()
        {
            func = new ScenarioLogic();
            func.invoke();
            func.get_users();
        }
        
        [Then(@"The registeration should be successfull")]
        public void ThenTheRegisterationShouldBeSuccessfull()
        {
            Assert.IsTrue(func.check_registration());
        }
        
        [Then(@"Token shoud be returned")]
        public void ThenTokenShoudBeReturned()
        {
            Assert.IsTrue(func.token_generation());
        }
        
        [Then(@"The registeration should not be successfull")]
        public void ThenTheRegisterationShouldNotBeSuccessfull()
        {
            Assert.IsFalse(func.check_registration());
        }
        
        [Then(@"should be getting a list of users")]
        public void ThenShouldBeGettingAListOfUsers()
        {
            Assert.IsTrue(func.check_responseNusers());
        }
    }
}
