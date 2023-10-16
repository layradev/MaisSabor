using System.Numerics;
using Microsoft.AspNetCore.Mvc;
namespace InduMovel.Areas.Admin.Controllers
{
    public class AdminController : Controller
    {
        public AdminController()
        {
        }

        [Area("Admin")]
        public IActionResult Index()
        {
            return View();
        }
    }
}