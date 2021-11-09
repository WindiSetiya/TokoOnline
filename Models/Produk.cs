using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace MvcTokoOnline.Models
{
    public class Produk
    {
        public int ID { get; set; }
        public string Nama { get; set; }
        public string Ukuran { get; set; }
        public double Harga { get; set; }
        public int KategoriID { get; set; }
        public virtual Kategori Kategori { get; set; }
        public virtual List<Transaksi> transaksi{ get; set; }

    }
}