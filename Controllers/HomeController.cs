using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Identity.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Identity.Controllers
{
    public class HomeController : Controller
    {
        //private UserManager<AppUser> userManager;
        // public HomeController(UserManager<AppUser> userMgr)
        // {
        //     userManager = userMgr;
        // }
        private NorthwindContext _northwindContext;
        public HomeController(NorthwindContext db) => _northwindContext = db;

        /*[Authorize]
        public IActionResult Index()
        {
            return View((object)"Hello");
        }*/
        public ActionResult Index() => View(_northwindContext.Discounts.Where(d => d.StartTime <= DateTime.Now && d.EndTime > DateTime.Now).Take(3));

        //[Authorize(Roles = "Manager")]
        //[Authorize]
        // public async Task<IActionResult> Index2()
        // {
        //     AppUser user = await userManager.GetUserAsync(HttpContext.User);
        //     string message = "Hello " + user.UserName;
        //     return View((object)message);
        // }
    }
}