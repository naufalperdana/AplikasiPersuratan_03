using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebAppReport03.DB;
using WebAppReport03.Models;

namespace WebAppReport03.Controllers
{
    public class TblSrtTugasController : Controller
    {
        private readonly AplikasiSuratContext _context;

        public TblSrtTugasController(AplikasiSuratContext context)
        {
            _context = context;
        }

        // GET: TblSrtTugas
        public async Task<IActionResult> Index()
        {
            return View(await _context.TblSrtTugass.ToListAsync());
        }

        // GET: TblSrtTugas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tblSrtTugas = await _context.TblSrtTugass
                .FirstOrDefaultAsync(m => m.IdSrtTgs == id);
            if (tblSrtTugas == null)
            {
                return NotFound();
            }

            return View(tblSrtTugas);
        }

        // GET: TblSrtTugas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TblSrtTugas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,No_Surat,Dasar_1,Dasar_2,Nama,NIP,Pangkat_Gol,Jabatan,Unit,Kegiatan,Hari_Tanggal_Keg,Tempat_Keg,Waktu_Keg,Tempat_ttd,Tanggal_ttd,Jabatan_ttd,Penandatangan")] TblSrtTugas tblSrtTugas)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tblSrtTugas);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tblSrtTugas);
        }

        // GET: TblSrtTugas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tblSrtTugas = await _context.TblSrtTugass.FindAsync(id);
            if (tblSrtTugas == null)
            {
                return NotFound();
            }
            return View(tblSrtTugas);
        }

        // POST: TblSrtTugas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,No_Surat,Dasar_1,Dasar_2,Nama,NIP,Pangkat_Gol,Jabatan,Unit,Kegiatan,Hari_Tanggal_Keg,Tempat_Keg,Waktu_Keg,Tempat_ttd,Tanggal_ttd,Jabatan_ttd,Penandatangan")] TblSrtTugas tblSrtTugas)
        {
            if (id != tblSrtTugas.IdSrtTgs)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tblSrtTugas);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TblSrtTugasExists(tblSrtTugas.IdSrtTgs))
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
            return View(tblSrtTugas);
        }

        // GET: TblSrtTugas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tblSrtTugas = await _context.TblSrtTugass
                .FirstOrDefaultAsync(m => m.IdSrtTgs == id);
            if (tblSrtTugas == null)
            {
                return NotFound();
            }

            return View(tblSrtTugas);
        }

        // POST: TblSrtTugas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tblSrtTugas = await _context.TblSrtTugass.FindAsync(id);
            _context.TblSrtTugass.Remove(tblSrtTugas);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TblSrtTugasExists(int id)
        {
            return _context.TblSrtTugass.Any(e => e.IdSrtTgs == id);
        }

        // GET: TblSrtTugas/Print/5
        public async Task<IActionResult> Print(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tblSrtTugas = await _context.TblSrtTugass
                .FirstOrDefaultAsync(m => m.IdSrtTgs == id);
            if (tblSrtTugas == null)
            {
                return NotFound();
            }

            return View(tblSrtTugas);
        }
    }
}
