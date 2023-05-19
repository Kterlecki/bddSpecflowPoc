namespace SpecFlow.POC
{
    public class Person
    {
        public string name;
        public Person(string namePassed)
        {
            name = namePassed;
        }
        public void MoveTo(int distance)
        {
            
        }

        public void Shouts(string message)
        {
            
        }

        public IEnumerable<string> GetMessagesHeard()
        {
            return new List<string> { "free bagels at Sean's" };
        }
    }
}