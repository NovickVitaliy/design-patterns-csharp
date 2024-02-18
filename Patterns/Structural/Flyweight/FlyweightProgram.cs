using Patterns.Structural.Flyweight.Models;

namespace Patterns.Structural.Flyweight;

public class FlyweightProgram
{
    public static void FlyweightMain(string[] args)
    {
        var company = CompanyFactory.GetCompanyByName("SomeCompany");
        Developer firstDeveloper = new Developer()
        {
            FirstName = "Vitalii",
            LastName = "Novik",
            ProgrammingLanguage = ProgrammingLanguage.CSharp,
            Company = company
        };
        
        Developer secondDeveloper = new Developer()
        {
            FirstName = "Some",
            LastName = "Dude",
            ProgrammingLanguage = ProgrammingLanguage.Java,
            Company = company
        };
        company.Developers.Add(firstDeveloper);
        company.Developers.Add(secondDeveloper);


        company = CompanyFactory.GetCompanyByName("AnotherCompany");
        Developer thirdDeveloper = new Developer()
        {
            FirstName = "Dude",
            LastName = "Again",
            ProgrammingLanguage = ProgrammingLanguage.Python,
            Company = company
        };

        Console.WriteLine(firstDeveloper.Company == secondDeveloper.Company);
        Console.WriteLine(thirdDeveloper.Company == secondDeveloper.Company);
    }
}