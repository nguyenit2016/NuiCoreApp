using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using NuiCoreApp.Data.Entities;
using System.Threading.Tasks;

namespace NuiCoreApp.Areas.Admin.Controllers
{
    public class AccountController : AdminBaseController
    {
        private readonly SignInManager<AppUser> _signInManager;

        public AccountController(SignInManager<AppUser> signInManager)
        {
            _signInManager = signInManager;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return Redirect("/Admin/Login/Index");
        }
    }
}