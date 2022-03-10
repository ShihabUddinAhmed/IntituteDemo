using System.ComponentModel.DataAnnotations;

namespace Institute.Models
{
    public class Student
    {
        /*private string _id;
        private string _name;
        private string _email;
        private string _phone;
        private string _address;
        private int _age;
        private string _dob;
        private string _gender;
        private string _fathername;
        private string _mothername;
        private string _identificationno;
*/      
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int Address { get; set; }
        public string FatherName { get; set; }
        public string MotherName { get; set; }
        public string IdentificationNumber { get; set; }
        public bool IsActive { get; set; }
    }
}
