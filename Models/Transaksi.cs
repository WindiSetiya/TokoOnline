using System;
using System.ComponentModel.DataAnnotations;

namespace MvcTokoOnline.Models
{
    public class Transaksi
    {
        public int ID { get; set; }
        public int SistemPembayaranID { get; set; }
        public string CustomerID  { get; set; }

        [DataType(DataType.Date)]
        public DateTime TanggalPembayaran { get; set; }
    }
}