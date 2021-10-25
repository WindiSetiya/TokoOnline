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

namespace MvcTokoOnline.Controllers
{
    public class TokoOnlineController : Controller
    {
        MvcTokoOnlineDbContext _context;
        public TokoOnlineController (MvcTokoOnlineDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public string Index(string searchString, bool notUsed)
        {
            return "From [HttpPost]Index: filter on" + searchString;
        }

public IActionResult Index( string searchString)
{
    var category = from m in _context.categories
                 select m;
    if (!string.IsNullOrEmpty(searchString))
    {
        category = category.Where(s => s.Nama.Contains(searchString));
    }
    return View(category);
}

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login([Bind("ID, Email, Password")] Customer customer)
        {
            if (ModelState.IsValid)
            {
                _context.customers.Add(customer);
                await _context.SaveChangesAsync();
            }
            return View(customer);
        }
    }
}