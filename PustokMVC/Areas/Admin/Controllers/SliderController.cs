using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PustokMVC.Contexts;
using PustokMVC.Models;

namespace PustokMVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SliderController : Controller
    {
        PustokDbContext _context;
        public SliderController(PustokDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
   
            //var model = db.HeroSliders.OrderBy(p => p.Id).Take(2);
            //return View(model);
            return View(await _context.HeroSliders.ToListAsync()); //4.4
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
            await _context.HeroSliders.AddAsync(slider);
            await _context.SaveChangesAsync();
            return View();
        }
    }
}
