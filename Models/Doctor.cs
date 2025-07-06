using System.ComponentModel.DataAnnotations;
namespace UsersApp.Models
{
    public class Doctor
    {
        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; } = string.Empty;

        [Required]
        public string LastName { get; set; } = string.Empty;

        [Required]
        public string CountryCode { get; set; } = string.Empty;


        [Required(ErrorMessage = "Phone number is required")]
        [Phone(ErrorMessage = "Invalid phone number")]
        public string PhoneNumber { get; set; } = string.Empty;

        [Required]
        public string Speciality { get; set; } = string.Empty;

        [Required]
        public string City { get; set; } = string.Empty;

    }




}

