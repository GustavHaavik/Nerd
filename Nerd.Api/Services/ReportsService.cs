using Nerd.Api.Contracts;
using Nerd.Api.Models;

namespace Nerd.Api.Services;

public class ReportsService : IReportsService
{
    private static readonly Dictionary<Guid, Person> _people = new();

    public void CreatePerson(Person person)
    {
        _people.Add(person.Id, person);
    }
}