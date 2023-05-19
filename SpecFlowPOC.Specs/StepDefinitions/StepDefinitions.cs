using SpecFlow.POC;
using System;
using TechTalk.SpecFlow;
using Xunit;

namespace SpecFlowPOC.Specs.StepDefinitions
{
    [Binding]
    public class StepDefinitions
    {
        //private Person lucy = new Person("Lucy");
        //private Person sean = new Person("Sean");
        private string messageFromSean;
        private Network network;
        private Dictionary<string, Person> people;

        [BeforeScenario]
        public void CreateNetwork()
        {
            network = new Network();
            people = new Dictionary<string, Person>();
        }

        [Given(@"a person named {word}")]
        public void GivenAPersonNamedLucy(string name)
        {
            people.Add(name, new Person(network));
        }

        

        [When(@"Sean shouts ""(.*)""")]
        public void WhenSeanShouts(string message)
        {
            people["Sean"].Shouts(message);
            messageFromSean = message;
        }

        [Then(@"Lucy hears Sean's message")]
        public void ThenLucyHearsSeansMessage()
        {
            Assert.Contains(messageFromSean, people["Lucy"].GetMessagesHeard());
        }
    }
}
