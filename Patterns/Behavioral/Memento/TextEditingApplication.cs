namespace Patterns.Behavioral.Memento;

public class TextEditingApplication
{
    private Stack<TextBox.SavedState> _savedStates = new();
    private TextBox _textBox;
    
    public TextEditingApplication()
    {
        _textBox = new TextBox();
    }

    public void SetFont(string fontName)
    {
        _textBox.Font = fontName;
    }

    public void SetFontSize(int fontSize)
    {
        _textBox.FontSize = fontSize;
    }

    public void CheckUnderline()
    {
        _textBox.Underlined = !_textBox.Underlined;
    }

    public void SetText(string text)
    {
        _textBox.Text = text;
    }

    public void Save()
    {
        _savedStates.Push(_textBox.Save());
    }

    public void Undo()
    {
        if (_savedStates.Count > 0)
        {
            var savedState = _savedStates.Pop();
            Console.WriteLine($"Before Undo(): {_textBox.ToString()}");
            _textBox.Restore(savedState);
            Console.WriteLine($"After Undo(): {_textBox.ToString()}");
            Console.WriteLine("======================================");
        }
        else
        {
            Console.WriteLine("Nothing to undo");
        }
    }

    public void CheckState()
    {
        Console.WriteLine(_textBox.ToString());
    }
}