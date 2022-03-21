using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplicationClient.Models
{
    public class EmployeeModel
    {
        public int id { get; set; }
        [Required(ErrorMessage ="Ce champ est obligatoire")]
        [Display(Name ="Prénom")]
        public string firstName { get; set; }
        [Display(Name = "Nom")]
        public string lastName { get; set; }
        [Display(Name = "Salaire")]
        public double salary { get; set; }
    }
}