using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PustokMVC.Contexts;
using PustokMVC.Models;

namespace PustokMVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SliderController : Controller
    {
        public async Task<IActionResult> Index()
        {
            using PustokDbContext db = new PustokDbContext();
            return View(await db.HeroSliders.ToListAsync()); //4.4
        }
        public async Task<IActionResult> Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(HeroSlider slider)
        {
            if (!ModelState.IsValid )
            {
                
                return View(slider);
            }
            using PustokDbContext db = new PustokDbContext();
            await db.HeroSliders.AddAsync(slider);
            await db.SaveChangesAsync();
            return View();
        }
    }
}
