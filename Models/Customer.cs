using System;
using System.ComponentModel.DataAnnotations;

namespace MvcTokoOnline.Models
{
    public class Customer
    {
        public int ID { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}