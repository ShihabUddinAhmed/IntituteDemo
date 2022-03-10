using System.ComponentModel.DataAnnotations;

namespace Institute.Models
{
    public class StudentViewModel
    {
        public Guid Id { get; set; }
        [Required(ErrorMessage = "Name is required")]
        [MaxLength(150)]
        public string Name { get; set; }
        [Required(ErrorMessage = "Age is required"), Range(0, int.MaxValue, ErrorMessage = "Please enter your age in number.")]
        public int Age { get; set; }
        [Required(ErrorMessage = "Please Select your gender")]
        public string Gender { get; set; }
        [Required(ErrorMessage = "Please specify your date of birth")]
        public DateTime DateOfBirth { get; set; }
        [Required(ErrorMessage = "Contact no is required")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Email is Required")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Address is required")]
        public int Address { get; set; }
        [Required(ErrorMessage = "Father's name is required")]
        public string FatherName { get; set; }
        [Required(ErrorMessage = "Mother's name is required")]
        public string MotherName { get; set; }
        [Required(ErrorMessage = "NID / Birth Certification No name is required")]
        public string IdentificationNumber { get; set; }
    }
}
