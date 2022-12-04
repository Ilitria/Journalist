using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Journalist.Models;
using Journalist.Models.Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Journalist.Controllers
{
    public class MarkController : Controller
    {
        private readonly AppDbContext _context;

        public MarkController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.Marks.ToListAsync());
        }

        public IActionResult AddOrEdit(int id=0)
        {
            if(id==0)
                return View(new Mark());
            else
                return View(_context.Marks.Find(id));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddOrEdit([Bind("Id,Name,Password,AcessLevel,Email,EmailVerefied")] Mark mark)
        {
            if(ModelState.IsValid)
            {
                if (mark.Id == 0)
                    _context.Add(mark);
                else
                    _context.Update(mark);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(mark);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var mark = await _context.Marks.FindAsync(id);
            _context.Marks.Remove(mark);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}