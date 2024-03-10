namespace Patterns.Behavioral.TemplateMethod.Base;

public abstract class BaseArchivator
{
    public void ArchiveFile(string fileName)
    {
        var file = GetFileToArchive();
        CompressFile();
        CreateArchivedFiles();
        Encrypt();
        GiveNameToFile(fileName);
        Verificate();
        GetArchivedFile(file);
    }

    private object GetFileToArchive()
    {
        Console.WriteLine("Retrieving file to archive");
        return new object();
    }

    private void GiveNameToFile(string name)
    {
        Console.WriteLine($"Assigning name {name} to file");
    }
    
    
    protected abstract void CompressFile();
    protected abstract void CreateArchivedFiles();
    protected abstract void Encrypt();

    protected virtual void Verificate()
    {
        
    }

    private object GetArchivedFile(object file)
    {
        return new { File=file, Size=Random.Shared.Next(10), SizeUnit="gb"};
    }
}