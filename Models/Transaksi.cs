using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;


namespace MvcTokoOnline.Models
{
    public class Transaksi
    {
        public int ID { get; set; }
        public int ProdukID { get; set; }
        public virtual Produk Produk { get; set; }
        public int SistemPembayaranID { get; set; }
        public virtual SistemPembayaran SistemPembayaran { get; set; }
        public string CustomerID  { get; set; }
        public virtual Customer Customer { get; set; }

        [DataType(DataType.Date)]
        public DateTime TanggalPembayaran { get; set; }
    }
}