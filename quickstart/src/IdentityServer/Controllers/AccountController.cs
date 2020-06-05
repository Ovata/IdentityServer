using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IdentityServer.ViewModel;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace IdentityServer.Controllers
{
    [Controller]
    public class AccountController : Controller
    {
        // GET: /<controller>/
        [HttpPost]
        public IActionResult Register([FromBody] RegistrationViewModel viewModel)
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }
    }
}
