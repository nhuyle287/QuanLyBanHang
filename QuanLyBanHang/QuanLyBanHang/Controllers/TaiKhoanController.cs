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
    public class TaiKhoanController : Controller
    {
        private readonly QuanLyBanHangDbContext _context;

        public TaiKhoanController(QuanLyBanHangDbContext context)
        {
            _context = context;
        }

        // GET: TaiKhoan
        public async Task<IActionResult> Index()
        {
            var quanLyBanHangDbContext = _context.TaiKhoan.Include(t => t.VaiTro);
            return View(await quanLyBanHangDbContext.ToListAsync());
        }

        //Get:TaiKhoan/Admin-NhanVien
        public IActionResult GetAdmin_NhanVien()
        {
            var quanlyAdmin_nhanvien = from ad in _context.TaiKhoan
                                       join vtro in _context.VaiTro
                                       on ad.VaiTroId equals vtro.VaiTroId
                                       where vtro.VaiTroId == 1 || vtro.VaiTroId == 2
                                       select ad;


            ViewBag.quanlyAdmin_nhanvien = quanlyAdmin_nhanvien;

            return View();
        }

        // GET: TaiKhoan/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var taiKhoan = await _context.TaiKhoan
                .Include(t => t.VaiTro)
                .FirstOrDefaultAsync(m => m.TaiKhoanId == id);
            if (taiKhoan == null)
            {
                return NotFound();
            }

            return View(taiKhoan);
        }

        // GET: TaiKhoan/Create
        public IActionResult Create()
        {
            ViewData["VaiTroId"] = new SelectList(_context.VaiTro, "VaiTroId", "VaiTroId");
            return View();
        }

        // POST: TaiKhoan/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TaiKhoanId,Username,Password,NgayTao,VaiTroId")] TaiKhoan taiKhoan)
        {
            if (ModelState.IsValid)
            {
                _context.Add(taiKhoan);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["VaiTroId"] = new SelectList(_context.VaiTro, "VaiTroId", "VaiTroId", taiKhoan.VaiTroId);
            return View(taiKhoan);
        }

        // GET: TaiKhoan/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var taiKhoan = await _context.TaiKhoan.FindAsync(id);
            if (taiKhoan == null)
            {
                return NotFound();
            }
            ViewData["VaiTroId"] = new SelectList(_context.VaiTro, "VaiTroId", "VaiTroId", taiKhoan.VaiTroId);
            return View(taiKhoan);
        }

        // POST: TaiKhoan/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("TaiKhoanId,Username,Password,NgayTao,VaiTroId")] TaiKhoan taiKhoan)
        {
            if (id != taiKhoan.TaiKhoanId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(taiKhoan);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TaiKhoanExists(taiKhoan.TaiKhoanId))
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
            ViewData["VaiTroId"] = new SelectList(_context.VaiTro, "VaiTroId", "VaiTroId", taiKhoan.VaiTroId);
            return View(taiKhoan);
        }

        // GET: TaiKhoan/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var taiKhoan = await _context.TaiKhoan
                .Include(t => t.VaiTro)
                .FirstOrDefaultAsync(m => m.TaiKhoanId == id);
            if (taiKhoan == null)
            {
                return NotFound();
            }

            return View(taiKhoan);
        }

        // POST: TaiKhoan/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var taiKhoan = await _context.TaiKhoan.FindAsync(id);
            _context.TaiKhoan.Remove(taiKhoan);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TaiKhoanExists(int id)
        {
            return _context.TaiKhoan.Any(e => e.TaiKhoanId == id);
        }
    }
}
