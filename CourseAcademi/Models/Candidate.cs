using System.ComponentModel.DataAnnotations;

namespace CourseAcademi.Models
{
    public class Candidate
    {
        [Required(ErrorMessage = "E-mail is Required")]
        public String? Email { get; set; } = String.Empty;

        [Required(ErrorMessage = "First Name is Required")]
        public String? FirstName { get; set; } = String.Empty;

        [Required(ErrorMessage = "Last Name is Required")]
        public String? LastName { get; set; } = String.Empty;
        
        public String? FullName => $"{FirstName} {LastName?.ToUpper()}";
        public int Age { get; set; }
        public String? SelectedCourse { get; set; } = String.Empty;
        public DateTime ApplyAt { get; set; }

        public Candidate()
        {
            ApplyAt = DateTime.Now;
        }
    }
}