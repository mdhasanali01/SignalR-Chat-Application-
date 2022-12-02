using Microsoft.AspNetCore.Mvc;

namespace ChatApplication_WithSignalR.Controllers
{
    public class ChatController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
