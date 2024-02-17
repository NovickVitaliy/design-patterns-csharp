using Patterns.Creational.Prototype.Models;

namespace Patterns.Creational.Prototype;

public class PrototypeProgram
{
    public static void PrototypeMain(string[] args)
    {
        Student student = new Student()
        {
            FirstName = "Vitalii",
             LastName = "Novik",
             Age = 18,
             University = new University()
             {
                 Name = "CHNU"
             }
        };

        var studentClone = student.Clone();

        Console.WriteLine(student == studentClone);
        Console.WriteLine(student.University == studentClone.University);
        
    }
}