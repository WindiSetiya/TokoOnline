using Microsoft.EntityFrameworkCore;
using MvcTokoOnline.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace MvcTokoOnline.Data
{
    public class MvcTokoOnlineDbContext : IdentityDbContext<Customer>
    {
        public MvcTokoOnlineDbContext (DbContextOptions<MvcTokoOnlineDbContext> options) : base(options)
        { }
    }
}