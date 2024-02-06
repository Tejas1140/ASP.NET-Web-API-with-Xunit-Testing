using Microsoft.AspNetCore.Mvc;

namespace WebApp2.ApplicationLayer.Controllers.V1
{
    public class AgentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
