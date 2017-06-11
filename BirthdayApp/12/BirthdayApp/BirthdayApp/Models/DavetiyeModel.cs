using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BirthdayApp.Models
{
    public class DavetiyeModel
    {
        [Required]
        public string Ad { get; set; }

        [Required]
        public string Eposta { get; set; }

        [Required]
        public bool? KatilmaDurumu { get; set; }
    }
}