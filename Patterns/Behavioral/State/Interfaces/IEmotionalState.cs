using Patterns.Behavioral.State.Models;

namespace Patterns.Behavioral.State.Interfaces;

public interface IEmotionalState
{
    Person Person { set; }
    void Workout();
    void Rest();
    void Sleep();
    void Eat();
}