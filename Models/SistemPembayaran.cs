using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;


namespace MvcTokoOnline.Models
{
    public class SistemPembayaran
    {
        public int ID { get; set; }
        public string MetodePembayaran { get; set; }
        public virtual List<Transaksi> Transaksis { get; set; }

    }
}