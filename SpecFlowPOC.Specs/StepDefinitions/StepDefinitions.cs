using SpecFlow.POC;
using System;
using TechTalk.SpecFlow;
using Xunit;

namespace SpecFlowPOC.Specs.StepDefinitions
{
    [Binding]
    public class StepDefinitions
    {
        private Person lucy = new Person("Lucy");
        private Person sean = new Person("Sean");

        private string messageFromSean;

        [Given(@"Lucy is located (.*)m from Sean")]
        public void GivenLucyIsLocatedMFromSean( int distance)
        { 
            lucy.MoveTo(distance);
        }

        [When(@"Sean shouts ""(.*)""")]
        public void WhenSeanShouts(string message)
        {
            sean.Shouts(message);
            messageFromSean = message;
        }

        [Then(@"Lucy hears Sean's message")]
        public void ThenLucyHearsSeansMessage()
        {
            Assert.Contains(messageFromSean, lucy.GetMessagesHeard());
        }
    }
}
