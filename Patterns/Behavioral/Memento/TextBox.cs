namespace Patterns.Behavioral.Memento;

public class TextBox
{
    private string _text;
    private string _font;
    private int _fontSize;
    private bool _underlined;

    public override string ToString()
    {
        return $"{nameof(_text)}: {_text}, {nameof(_font)}: {_font}, {nameof(_fontSize)}: {_fontSize}, {nameof(_underlined)}: {_underlined}";
    }

    public string Text
    {
        get => _text;
        set => _text = value ?? throw new ArgumentNullException(nameof(value));
    }

    public string Font
    {
        get => _font;
        set => _font = value ?? throw new ArgumentNullException(nameof(value));
    }

    public int FontSize
    {
        get => _fontSize;
        set => _fontSize = value;
    }

    public bool Underlined
    {
        get => _underlined;
        set => _underlined = value;
    }

    public SavedState Save()
    {
        return new SavedState(this);
    }

    public void Restore(SavedState savedState)
    {
        _text = savedState.Text;
        _font = savedState.Font;
        _underlined = savedState.Underlined;
        _fontSize = savedState.FontSize;
    }

    public class SavedState
    {
        private string _text;
        private string _font;
        private int _fontSize;
        private bool _underlined;
        private DateTime _dateSaved;

        public string GetName()
        {
            return $"State saved on: {_dateSaved:g}";
        }
        public string Text => _text;

        public string Font => _font;

        public int FontSize => _fontSize;

        public bool Underlined => _underlined;

        public DateTime DateSaved => _dateSaved;

        public SavedState(TextBox textBox)
        {
            _text = textBox._text;
            _font = textBox._font;
            _fontSize = textBox._fontSize;
            _underlined = textBox._underlined;
            _dateSaved = DateTime.UtcNow;
        }
    } 
}