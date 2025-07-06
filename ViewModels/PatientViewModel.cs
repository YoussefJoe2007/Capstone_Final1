using System.ComponentModel.DataAnnotations;

namespace UsersApp.ViewModels
{
    public class PatientViewModel
    {
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Range(0, 150)]
        public int Age { get; set; }

        [Range(0.0, 500.0)]
        public double Weight { get; set; }

        [Required]
        public string Gender { get; set; }
    }

}
