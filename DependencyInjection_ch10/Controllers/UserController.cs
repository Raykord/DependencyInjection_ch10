using DependencyInjection_ch10.Services;
using Microsoft.AspNetCore.Mvc;

namespace DependencyInjection_ch10.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : Controller
    {
        private readonly IEmailSender _emailSender;

        public UserController(IEmailSender emailSender)
        {
            _emailSender = emailSender;
        }

        [HttpPost("register")]
        public IActionResult RegisterUser(string username)
        {
            _emailSender.SendEmail(username);
            return Ok();
        }

    }
}
