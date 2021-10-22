using System;
using System.ComponentModel.DataAnnotations;

namespace MvcTokoOnline.Models
{
    public class Produk
    {
        public int ID { get; set; }
        public string Nama { get; set; }
        public string Ukuran { get; set; }
        public string KategoriID { get; set; }
    }
}