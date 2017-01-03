using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCEvening.ViewModels
{
    public class CustomerForm
    {
        public int Id { get; set; }
        [Required, Display(Name = "Customer Name")]
        public string CustomerName { get; set; }
        [Required]
        public string CustomerAddress { get; set; }
        [Required]
        public string CustomerPhone { get; set; }



     }
}