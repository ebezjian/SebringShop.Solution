using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using SebringShop.Services;
using SebringShop.Entities;



namespace SebringShop.Controllers
{
  [Authorize]
  [ApiController]
  [Route("/api/[controller]")]
  public class UsersController : ControllerBase
  {
    private IUserService _userService;
    public UsersController(IUserService userService)
    {
      _userService = userService;
    }

    [AllowAnonymous]  
    [HttpPost("authenticate")]
    public IActionResult Authenticate([FromBody]User userParam)
    {
      var user = _userService.Authenticate(userParam.Username, userParam.Password);

      if (user == null)
      {
        return BadRequest(new { message = "Username or password is incorrect"});
      }
      return Ok(user);
    }

  }
}