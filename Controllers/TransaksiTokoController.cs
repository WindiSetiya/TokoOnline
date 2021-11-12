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
    [Authorize]
    public class TransaksiTokoController : Controller
    {
        MvcTokoOnlineDbContext _context;
        private UserManager<Customer> _userManager;
        public TransaksiTokoController (MvcTokoOnlineDbContext context, UserManager<Customer> userManager)
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

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Transaksi([Bind("ID, ProdukID, SistemPembayaranID, CustomerID, Tanggal Pembayaran")] Transaksi transaction)
        {
            if (ModelState.IsValid)
            {
                _context.transaksi.Add(transaction);
                await _context.SaveChangesAsync();
                 return RedirectToAction("Result");
            }
            return View(transaction);
        }
        public IActionResult Transaksi()
        {
            return View();
        }
        public IActionResult Result()
        {
            return View();
        }
    }
}