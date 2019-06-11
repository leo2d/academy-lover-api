using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AcademyLover.Models.ViewModels
{
    public class LoginViewModel
    {
        [Required]
        public string Login { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
