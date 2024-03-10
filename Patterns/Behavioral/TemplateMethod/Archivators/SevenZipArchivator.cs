using Patterns.Behavioral.TemplateMethod.Base;

namespace Patterns.Behavioral.TemplateMethod.Archivators;

public class SevenZipArchivator : BaseArchivator 
{
    protected override void Verificate()
    {
        Console.WriteLine("Verificating file using 7Zip technologies");
    }

    protected override void CompressFile()
    {
        Console.WriteLine("Compressing file using 7Zip technologies");
    }

    protected override void CreateArchivedFiles()
    {
        Console.WriteLine("Creating archived file using 7Zip technologies");
    }

    protected override void Encrypt()
    {
        Console.WriteLine("Ecrypting file using 7Zip technologies");
    }
}