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

    public Person? GetPerson(Guid id)
    {
        if (!_people.ContainsKey(id)) return null;
        return _people[id];
    }

    public GeoLocation UpdateLocation(Guid id, GeoLocation location)
    {
        var person = _people[id];
        person.Location = location;
        return location;
    }
}