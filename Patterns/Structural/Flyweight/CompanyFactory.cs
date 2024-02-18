using Patterns.Structural.Flyweight.Models;

namespace Patterns.Structural.Flyweight;

public static class CompanyFactory
{
    private static Dictionary<string, Company> _companies = new();

    public static Company GetCompanyByName(string name)
    {
        if (_companies.ContainsKey(name))
        {
            return _companies[name];
        }

        Company company = new Company()
        {
            Name = name,
        };
        _companies.Add(name, company);
        return company;
    }
}