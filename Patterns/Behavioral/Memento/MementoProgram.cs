namespace Patterns.Behavioral.Memento;

public class MementoProgram
{
    public static void MementoMain(string[] args)
    {
        TextEditingApplication application = new TextEditingApplication();
        
        application.SetText("Hello world");
        application.SetFont("some font");
        application.SetFontSize(15);
        application.Save();
        
        application.SetText("Hello world again");
        application.SetFont("some font again");
        application.SetFontSize(18);
        application.CheckUnderline();
        application.Save();
        
        application.SetText("DASDADASDASD");
        application.SetFont("DSADASDASDASDASD");
        application.SetFontSize(18);
        
        application.CheckState();
        application.Undo();
        application.Undo();
        application.Undo();
    }
}