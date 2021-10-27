using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MvcTokoOnline.Models
{
    public class Kategori
    {
        public int ID { get; set; }
        public string Nama { get; set; }
        public virtual List<Produk> product { get; set; }
    }
}