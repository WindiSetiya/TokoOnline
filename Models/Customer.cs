using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace MvcTokoOnline.Models
{
    public class Customer : IdentityUser
    {
        public virtual List<Transaksi> transaksi { get; set; }
        public string Avatar { get; internal set; }
    }
}