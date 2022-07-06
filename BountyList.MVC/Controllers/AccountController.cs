using BountyList.MVC.Controllers.Base;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BountyList.MVC.Controllers
{
    public class AccountController : BaseController
    {
        public AccountController(BaseControllerInitArgument initArgument) : base(initArgument)
        {

        }

        public IActionResult Index()
        {
            return View();
        }

        [AllowAnonymous]
        public IActionResult SignUp()
        {
            return View();
        }

        [AllowAnonymous]
        [HttpPost]
        public IActionResult SignUp(string email, string password)
        {
            return View();
        }

        [AllowAnonymous]
        public IActionResult Login()
        {
            return View();
        }
    }
}
