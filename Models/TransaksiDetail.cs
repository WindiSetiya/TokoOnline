using System;
using System.ComponentModel.DataAnnotations;

namespace MvcTokoOnline.Models
{
    public class TransaksiDetail
    {
        public int ID { get; set; }
        public int ProdukID { get; set; }
        public int TransaksiID { get; set; }
        public double Jumlah { get; set; }
    }
}