using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using webprojtest3.Data;
using webprojtest3.Models;

namespace webprojtest3.Controllers
{
    public class CoursePapersController : Controller
    {
        private readonly GymContext _context;

        public CoursePapersController(GymContext context)
        {
            _context = context;
        }

        // GET: CoursePapers
        public async Task<IActionResult> Index()
        {
            return View(await _context.CoursePaper.ToListAsync());
        }

        // GET: CoursePapers/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var coursePaper = await _context.CoursePaper
                .FirstOrDefaultAsync(m => m.CoursePaperID == id);
            if (coursePaper == null)
            {
                return NotFound();
            }

            return View(coursePaper);
        }

        // GET: CoursePapers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CoursePapers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CoursePaperID,CourseName")] CoursePaper coursePaper)
        {
            if (ModelState.IsValid)
            {
                _context.Add(coursePaper);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(coursePaper);
        }

        // GET: CoursePapers/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var coursePaper = await _context.CoursePaper.FindAsync(id);
            if (coursePaper == null)
            {
                return NotFound();
            }
            return View(coursePaper);
        }

        // POST: CoursePapers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("CoursePaperID,CourseName")] CoursePaper coursePaper)
        {
            if (id != coursePaper.CoursePaperID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(coursePaper);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CoursePaperExists(coursePaper.CoursePaperID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(coursePaper);
        }

        // GET: CoursePapers/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var coursePaper = await _context.CoursePaper
                .FirstOrDefaultAsync(m => m.CoursePaperID == id);
            if (coursePaper == null)
            {
                return NotFound();
            }

            return View(coursePaper);
        }

        // POST: CoursePapers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var coursePaper = await _context.CoursePaper.FindAsync(id);
            _context.CoursePaper.Remove(coursePaper);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CoursePaperExists(string id)
        {
            return _context.CoursePaper.Any(e => e.CoursePaperID == id);
        }
    }
}
