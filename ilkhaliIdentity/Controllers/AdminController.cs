using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ilkhaliIdentity.Controllers
{
    public class AdminController : Controller
    {

        private UserManager<IdentityUser> _userManager { get; }

        public AdminController(UserManager<IdentityUser> userManager)
        {
            _userManager = userManager;
        }
        public IActionResult Index()
        {
           var user= _userManager.Users.ToList();

            return View(user);
        }
    }
}
