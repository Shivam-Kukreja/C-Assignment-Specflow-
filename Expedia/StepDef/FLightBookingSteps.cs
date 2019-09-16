using System;
using Expedia.BusinessLogic;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace Expedia.StepDef
{
    [Binding]
    public class FLightBookingSteps
    {
        static HomeBL obj;
        static FlightReviewAndSelecionBL obj1;
        [Given(@"I am on the expedia home page")]
        public void GivenIAmOnTheExpediaHomePage()
        {
            obj = new HomeBL();
            Assert.IsTrue(obj.check_Homepage());
        }
        
        [When(@"I click on flight button and select's multi city option")]
        public void WhenIClickOnFlightButtonAndSelectSMultiCityOption()
        {
            obj.click_flight();
        }

        [Then(@"I go for three different flight leg's between airports (.*),(.*),(.*) on dates (.*),(.*),(.*)  for (.*) adults")]
        public void ThenIGoForThreeDifferentFlightLegSBetweenAirportsOnDatesForAdults(string p0, string p1, string p2, string p3, string p4, string p5, string p6)
        {
            obj.built_Itenary(p0, p1, p2, p3, p4,  p5, p6);
        }


        [Then(@"I choose the first available option")]
        public void ThenIChooseTheFirstAvailableOption()
        {
            obj1 = new FlightReviewAndSelecionBL();
            Assert.IsTrue(obj1.pick_flight());
        }

        [Then(@"I make sure that the trip total is equal to price per person multiplied by the number of people ""(.*)""")]
        public void ThenIMakeSureThatTheTripTotalIsEqualToPricePerPersonMultipliedByTheNumberOfPeople(string p0)
        {
            Assert.IsTrue(obj1.Assert_Total(p0));
        }
    }
}
