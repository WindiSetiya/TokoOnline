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

namespace MvcTokoOnline.Controllers
{
    public class TokoOnlineController : Controller
    {
        MvcTokoOnlineDbContext _context;
        public TokoOnlineController (MvcTokoOnlineDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}