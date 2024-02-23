namespace Patterns.Behavioral.Iterator;

public interface IIterator<out T>
{
    bool HasNext();
    T GetNext();
}