using Microsoft.EntityFrameworkCore;
using MvcTokoOnline.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace MvcTokoOnline.Data
{
    public class MvcTokoOnlineDbContext : IdentityDbContext<Customer>
    {
        public MvcTokoOnlineDbContext (DbContextOptions<MvcTokoOnlineDbContext> options) : base(options)
        { }

        public DbSet<Kategori> categories { get; set; }
        public DbSet<Produk> product { get; set; }
        public DbSet<SistemPembayaran> sistemPembayarans { get; set; }
        public DbSet<Transaksi> transaksi { get; set; }
        public DbSet<TransaksiDetail> transaksiDetails { get; set; }
    }
}