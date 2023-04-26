using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace Scaffold_Test_User.Controllers
{
    public class RoleController : Controller
    {
        [Authorize(Roles  = "Administrator")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
