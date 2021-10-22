using Microsoft.EntityFrameworkCore;
using MvcTokoOnline.Models;

namespace MvcTokoOnline.Data
{
    public class MvcTokoOnlineDbContext : DbContext
    {
        public MvcTokoOnlineDbContext (DbContextOptions<MvcTokoOnlineDbContext> options) : base(options)
        { }
        public DbSet<Kategori> categories { get; set; }
        public DbSet<Customer> customers { get; set; }
        public DbSet<Produk> products { get; set; }
        public DbSet<Transaksi> transactions { get; set; }
        public DbSet<TransaksiDetail> transaksiDetails { get; set; }
        public DbSet<SistemPembayaran> sistemPembayarans { get; set; }
    
    }
}