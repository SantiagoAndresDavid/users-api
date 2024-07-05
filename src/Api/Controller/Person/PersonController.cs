using Entites;
using Microsoft.AspNetCore.Mvc;
using Service;


[ApiController]
[Route("person")]
public class PersonController : ControllerBase
{
    private readonly PersonService _personService;

    public PersonController(PersonService personService)
    {
        _personService = personService;
    }

    [HttpPost("sign-up")]
    public ActionResult SavePerson(Person person)
    {
        try
        {
            var response= _personService.SavePerson(person);
            return Ok(response);
        }
        catch (Exception e)
        {
            return BadRequest(e);
        }
    }
}
