using System;
using System.ComponentModel.DataAnnotations;

namespace MvcTokoOnline.Models
{
    public class TransaksiDetail
    {
        public int ID { get; set; }
        public string ProdukID { get; set; }
        public string TransaksiID { get; set; }
        public string Jumlah { get; set; }
    }
}