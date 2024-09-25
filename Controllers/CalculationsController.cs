using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MvcKap.Data;
using MvcKap.Models;

namespace MvcKap.Controllers
{
    public class CalculationsController : Controller
    {
        private readonly MvcKapContext _context;

        public CalculationsController(MvcKapContext context)
        {
            _context = context;
        }

        // GET: Calculations
        public async Task<IActionResult> Index()
        {
            return View(await _context.Calculations.ToListAsync());
        }

        // GET: Calculations/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var calculations = await _context.Calculations
                .FirstOrDefaultAsync(m => m.Id == id);
            if (calculations == null)
            {
                return NotFound();
            }

            return View(calculations);
        }

        // GET: Calculations/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Calculations/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,IvftRate,IvftBolusVolume,EphedrineConc,GlycopyrrolateConc,TranexamicAcidConc,KetamineConc,FentanylConc")] Calculations calculations)
        {
            if (ModelState.IsValid)
            {
                _context.Add(calculations);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(calculations);
        }

        // GET: Calculations/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var calculations = await _context.Calculations.FindAsync(id);
            if (calculations == null)
            {
                return NotFound();
            }
            return View(calculations);
        }

        // POST: Calculations/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,IvftRate,IvftBolusVolume,EphedrineConc,GlycopyrrolateConc,TranexamicAcidConc,KetamineConc,FentanylConc")] Calculations calculations)
        {
            if (id != calculations.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(calculations);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CalculationsExists(calculations.Id))
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
            return View(calculations);
        }

        // GET: Calculations/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var calculations = await _context.Calculations
                .FirstOrDefaultAsync(m => m.Id == id);
            if (calculations == null)
            {
                return NotFound();
            }

            return View(calculations);
        }

        // POST: Calculations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var calculations = await _context.Calculations.FindAsync(id);
            if (calculations != null)
            {
                _context.Calculations.Remove(calculations);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CalculationsExists(int id)
        {
            return _context.Calculations.Any(e => e.Id == id);
        }
    }
}
