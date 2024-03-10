using Patterns.Behavioral.TemplateMethod.Archivators;
using Patterns.Behavioral.TemplateMethod.Base;

namespace Patterns.Behavioral.TemplateMethod;

public class TemplateMethodProgram
{
    public static void Main(string[] args)
    {
        BaseArchivator archivator = new SevenZipArchivator();
        archivator.ArchiveFile("some.txt");
        archivator = new WinRarArchivator();
        Console.WriteLine("==============================================");
        archivator.ArchiveFile("another.txt");
    }
}