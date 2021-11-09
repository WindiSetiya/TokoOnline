using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Encodings.Web;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using MvcTokoOnline.Data;
using MvcTokoOnline.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;

namespace MvcTokoOnline.Controllers
{
    public class TokoOnlineController : Controller
    {
        MvcTokoOnlineDbContext _context;
        private UserManager<Customer> _userManager;
        public TokoOnlineController (MvcTokoOnlineDbContext context, UserManager<Customer> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            var userId = _userManager.GetUserId(User);
            var user = _context.Users.Find(userId);
            return View(user);
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Nama")] Kategori kategori)
        {
            if (ModelState.IsValid)
            {
                _context.Add(kategori);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(kategori));
            }
            return View(kategori);
        }
        public IActionResult Kategori()
        {
            return View(_context.categories.ToList());
        }
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var produk = await _context.product
                .FirstOrDefaultAsync(m => m.ID == id);
            if (produk == null)
            {
                return NotFound();
            }
            return View(produk);
        }
        public IActionResult MetodePembayaran()
        {
            return View(_context.sistemPembayarans.ToList());
        }


        public async Task<IActionResult> Transaksi(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var transaction = await _context.transaksi
                .FirstOrDefaultAsync(m => m.ID == id);
            if (transaction == null)
            {
                return NotFound();
            }
            return View(transaction);        
        }
        public IActionResult Result()
        {
            return View();
        }
    }
}