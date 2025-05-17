using System.ComponentModel.DataAnnotations;

namespace TableGrid.Models
{
    public class mTableGrid
    {
        //public int id { get; set; }
        //public string fname { get; set; }
        //public string lname { get; set; }
        //public string userName { get; set; }
        //public string password { get; set; }
        //public string? email { get; set; }
        //public int? age { get; set; }

        public int id { get; set; }

        [Required(ErrorMessage = "First name is required")]
        [Display(Name = "First Name")]
        public string fname { get; set; }

        [Required(ErrorMessage = "Last name is required")]
        [Display(Name = "Last Name")]
        public string lname { get; set; }

        [Required(ErrorMessage = "Username is required")]
        [Display(Name = "Username")]
        public string userName { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        public string password { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid email address")]
        [Display(Name = "Email")]
        public string email { get; set; }

        [Range(18, 100, ErrorMessage = "Age must be between 18 and 100")]
        [Display(Name = "Age")]
        public int age { get; set; }
    }
}
