using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PustokMVC.Contexts;

namespace PustokMVC.Controllers
{
    public class HomeController : Controller
    { 
        public async Task<IActionResult>  Index()
        {
            using PustokDbContext context = new PustokDbContext();      
            var sliders = await context.HeroSliders.ToListAsync();
            return View(sliders);
        }
    }
}