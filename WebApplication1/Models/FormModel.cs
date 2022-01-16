using System;
using System.ComponentModel.DataAnnotations;

namespace Lab2.Models
{
    public class FormModel
    {
        [Display(Name = "Imię")]
        public string Name { get; set; }
        [Display(Name = "Data Urodzenia")]
        public DateTime BirthDate { get; set; }
    }
}
