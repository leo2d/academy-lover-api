using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AcademyLover.Models.ViewModels
{
    public class UserViewModel : LoginViewModel
    {
        [Required]
        public string Name { get; set; }
        public int Profile { get; set; }

        [Required]
        public DateTime BirthDate { get; set; }
        public string Nationality { get; set; }
        public string Adress { get; set; }
        public string School { get; set; }
    }
}
