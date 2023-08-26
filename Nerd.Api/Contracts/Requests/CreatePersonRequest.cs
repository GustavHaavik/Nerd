using Nerd.Api.Models;

namespace Nerd.Api.Contracts
{
    public record CreatePersonRequest(
        string FirstName,
        string LastName,
        string Gender,
        int Age,
        bool IsAlive,
        GeoLocation Location
    );
}