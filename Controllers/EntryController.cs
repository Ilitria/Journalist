using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Journalist.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Journalist.Controllers
{
    public class EntryController : Controller
    {
        private readonly AppDbContext _context;

        public EntryController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.Entries.ToListAsync());
        }

        public IActionResult AddOrEdit(int id=0)
        {
            if(id==0)
                return View(new Entry());
            else
                return View(_context.Entries.Find(id));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddOrEdit([Bind("Id,UserId,Authors,Post,WorkPlace,ThemeOfWork,WorkHeader,Annotation,Path2Content,Type")] Entry entry)
        {
            if(ModelState.IsValid)
            {
                if (entry.Id == 0)
                    _context.Add(entry);
                else
                    _context.Update(entry);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(entry);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var entry = await _context.Entries.FindAsync(id);
            _context.Entries.Remove(entry);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}