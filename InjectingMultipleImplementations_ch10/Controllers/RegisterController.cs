using InjectingMultipleImplementations_ch10.Models;
using Microsoft.AspNetCore.Mvc;

namespace InjectingMultipleImplementations_ch10.Controllers
{
    public class RegisterController : Controller
    {
        private readonly IEnumerable<IMessageSender> _senders;

        public RegisterController(IEnumerable<IMessageSender> senders)
        {
            _senders = senders;
        }

        [HttpGet("register/{username}")]
        public IActionResult Users(string? username)
        {
            if (username == null)
            {
                return RedirectToAction("Index");
            }

            ViewBag.Username = username;
            foreach (var sender in _senders)
            {
                sender.SendMessage(username);
            }
            return this.View();
        }
    }
}
