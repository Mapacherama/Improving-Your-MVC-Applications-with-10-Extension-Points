using Paladin.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Paladin.ViewModels
{
    public class AddressVM: LogData
    {
        public string UserAgent { get; set; }
        [Display(Name = "Street Address")]
        [Required]
        public string StreetAddress { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string State { get; set; }
        [Required]
        public double Zip { get; set; }
        [Required]
        public bool IsMailing { get; set; }
    }
}
