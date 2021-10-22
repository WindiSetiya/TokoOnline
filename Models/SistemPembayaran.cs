using System;
using System.ComponentModel.DataAnnotations;

namespace MvcTokoOnline.Models
{
    public class SistemPembayaran
    {
        public int ID { get; set; }
        public string MetodePembayaran { get; set; }
    }
}