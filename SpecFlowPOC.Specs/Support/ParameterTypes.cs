using TechTalk.SpecFlow;

namespace SpecFlow.POC.Specs.Support;

[Binding]
public class ParameterTypes
{
    [StepArgumentTransformation]
    public Person ConvertPerson(string name)
    {
        return new Person(name);
    }
}