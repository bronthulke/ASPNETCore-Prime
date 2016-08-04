using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Models
{
    public class PrimeViewModel
    {
        [Required]
        [Display(Name = "Value to check")]
        public int Value { get; set; }

    }
}
