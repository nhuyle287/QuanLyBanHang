using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using QuanLyBanHang.Models;

namespace QuanLyBanHang.Controllers
{
    public class PhiShipController : Controller
    {
        private readonly QuanLyBanHangDbContext _context;

        public PhiShipController(QuanLyBanHangDbContext context)
        {
            _context = context;
        }

        // GET: PhiShip
        public async Task<IActionResult> Index()
        {
            return View(await _context.PhiShip.ToListAsync());
        }

        // GET: PhiShip/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var phiShip = await _context.PhiShip
                .FirstOrDefaultAsync(m => m.PhiShipId == id);
            if (phiShip == null)
            {
                return NotFound();
            }

            return View(phiShip);
        }

        // GET: PhiShip/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PhiShip/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PhiShipId,Quan,ChiPhi")] PhiShip phiShip)
        {
            if (ModelState.IsValid)
            {
                _context.Add(phiShip);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(phiShip);
        }

        // GET: PhiShip/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var phiShip = await _context.PhiShip.FindAsync(id);
            if (phiShip == null)
            {
                return NotFound();
            }
            return View(phiShip);
        }

        // POST: PhiShip/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PhiShipId,Quan,ChiPhi")] PhiShip phiShip)
        {
            if (id != phiShip.PhiShipId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(phiShip);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PhiShipExists(phiShip.PhiShipId))
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
            return View(phiShip);
        }

        // GET: PhiShip/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var phiShip = await _context.PhiShip
                .FirstOrDefaultAsync(m => m.PhiShipId == id);
            if (phiShip == null)
            {
                return NotFound();
            }

            return View(phiShip);
        }

        // POST: PhiShip/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var phiShip = await _context.PhiShip.FindAsync(id);
            _context.PhiShip.Remove(phiShip);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PhiShipExists(int id)
        {
            return _context.PhiShip.Any(e => e.PhiShipId == id);
        }
    }
}
