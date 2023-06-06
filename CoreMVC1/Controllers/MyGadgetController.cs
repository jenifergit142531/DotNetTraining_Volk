using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CoreMVC1.Models;

namespace CoreMVC1.Controllers
{
   
    public class MyGadgetController : Controller
    {
        private readonly GadgetContext _context;

        public MyGadgetController(GadgetContext context)
        {
            _context = context;
        }

        // GET: MyGadget

       
        public async Task<IActionResult> Index()
        {
              return _context.Gadgets != null ? 
                          View(await _context.Gadgets.ToListAsync()) :
                          Problem("Entity set 'GadgetContext.Gadgets'  is null.");
        }

        // GET: MyGadget/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Gadgets == null)
            {
                return NotFound();
            }

            var gadget = await _context.Gadgets
                .FirstOrDefaultAsync(m => m.GadgetId == id);
            if (gadget == null)
            {
                return NotFound();
            }

            return View(gadget);
        }

        // GET: MyGadget/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: MyGadget/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("GadgetId,GadgetName,Price,Quantity")] Gadget gadget)
        {
            if (ModelState.IsValid)
            {
                _context.Add(gadget);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(gadget);
        }

        // GET: MyGadget/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Gadgets == null)
            {
                return NotFound();
            }

            var gadget = await _context.Gadgets.FindAsync(id);
            if (gadget == null)
            {
                return NotFound();
            }
            return View(gadget);
        }

        // POST: MyGadget/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("GadgetId,GadgetName,Price,Quantity")] Gadget gadget)
        {
            if (id != gadget.GadgetId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(gadget);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GadgetExists(gadget.GadgetId))
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
            return View(gadget);
        }

        // GET: MyGadget/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Gadgets == null)
            {
                return NotFound();
            }

            var gadget = await _context.Gadgets
                .FirstOrDefaultAsync(m => m.GadgetId == id);
            if (gadget == null)
            {
                return NotFound();
            }

            return View(gadget);
        }

        // POST: MyGadget/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Gadgets == null)
            {
                return Problem("Entity set 'GadgetContext.Gadgets'  is null.");
            }
            var gadget = await _context.Gadgets.FindAsync(id);
            if (gadget != null)
            {
                _context.Gadgets.Remove(gadget);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool GadgetExists(int id)
        {
          return (_context.Gadgets?.Any(e => e.GadgetId == id)).GetValueOrDefault();
        }
    }
}
