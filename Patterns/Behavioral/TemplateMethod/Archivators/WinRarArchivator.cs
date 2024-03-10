using Patterns.Behavioral.TemplateMethod.Base;

namespace Patterns.Behavioral.TemplateMethod.Archivators;

public class WinRarArchivator : BaseArchivator
{
    protected override void CompressFile()
    {
        Console.WriteLine("Compressing file using WinRar technologies");
    }

    protected override void CreateArchivedFiles()
    {
        Console.WriteLine("Creating archived file using WinRar technologies");
    }

    protected override void Encrypt()
    {
        Console.WriteLine("Encrypting file using WinRar technologies");
    }
}