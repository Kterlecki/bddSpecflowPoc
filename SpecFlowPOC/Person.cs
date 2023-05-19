namespace SpecFlow.POC
{
    public class Person
    {
        private readonly Network network;
        private readonly List<string> messagesHeard = new List<string>();
        public Person(Network network)
        {
            this.network = network;
            network.Subscribe(this);
        }
        public void Shouts(string message)
        {
            network.Broadcast(message);
        }

        public IEnumerable<string> GetMessagesHeard()
        {
            return messagesHeard;
        }
    }
}