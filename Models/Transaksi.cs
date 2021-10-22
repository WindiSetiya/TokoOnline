using System;
using System.ComponentModel.DataAnnotations;

namespace MvcTokoOnline.Models
{
    public class Transaksi
    {
        public int ID { get; set; }
        public string SistemPembayaranID { get; set; }
        public string CustomerID  { get; set; }
        public string TanggalPembayaran { get; set; }
    }
}