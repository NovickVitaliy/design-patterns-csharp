using Patterns.Behavioral.State.Models;

namespace Patterns.Behavioral.State;

public class StateProgram
{
    public static void Main(string[] args)
    {
        Person person = new Person("Vitalii");
        
        person.Rest();
        
        person.Sleep();
        
        person.Workout();
        
        person.Workout();
        
        person.Eat();

        person.Workout();
        
        person.Eat();
        
        person.Rest();
        
        person.Workout();
        
        person.Rest();
    }
}