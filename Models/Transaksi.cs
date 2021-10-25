using System;
using System.ComponentModel.DataAnnotations;

namespace MvcTokoOnline.Models
{
    public class Transaksi
    {
        public int ID { get; set; }
        public int SistemPembayaranID { get; set; }
        public int CustomerID  { get; set; }
        public int TanggalPembayaran { get; set; }
    }
}