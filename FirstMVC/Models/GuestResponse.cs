using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace FirstMVC.Models
{
    public class GuestResponse
    {
        [Required(ErrorMessage = "Veuillez renseigner votre nom")]
        public string Nom { get; set; }
        [Required(ErrorMessage = "Veuillez renseigner votre prénom")]
        public string Prenom { get; set; }
        [Required(ErrorMessage = "Veuillez renseigner votre E-Mail")]
        public string Mail { get; set; }
        [Required(ErrorMessage = "Veuillez nous informer de votre présence")]
        public bool? presence { get; set; }
    }
}