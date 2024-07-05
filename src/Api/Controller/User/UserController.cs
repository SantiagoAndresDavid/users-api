using Entites;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;


[ApiController]
[Route("User")]
public class UserController : ControllerBase
{
    private readonly UserService _userService;

    public UserController(UserService userService)
    {
        _userService = userService;
    }

    [HttpPost("sign-up")]
    public ActionResult SignUp(User user)
    {
        try
        {
            string response = _userService.SaveUser(user);
            return Ok(response);
        }
        catch (Exception e)
        {
            return BadRequest(e);
        }
    }
}
