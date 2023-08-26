using Microsoft.AspNetCore.Mvc;
using Nerd.Api.Contracts;
using Nerd.Api.Models;
using Nerd.Api.Services;

namespace Nerd.Api;

[Route("[controller]")]
[ApiController]
public class ReportsController : ControllerBase
{
    private readonly IReportsService _reportsService;

    public ReportsController(IReportsService reportsService)
    {
        _reportsService = reportsService;
    }

    [HttpPost("create")]
    public IActionResult CreatePerson(CreatePersonRequest request)
    {
        var person = new Person(
            Guid.NewGuid(),
            request.FirstName,
            request.LastName,
            request.Gender,
            request.Age,
            request.IsAlive,
            request.Location
        );

        _reportsService.CreatePerson(person);

        // Kunne bruge en mapper til a Mappe fra Person til PersonResponse
        var response = new PersonResponse(
                    person.Id,
                    person.FirstName,
                    person.LastName,
                    person.Gender,
                    person.Age,
                    person.IsAlive,
                    person.Location
                ); ;

        return Ok(response);
    }
}