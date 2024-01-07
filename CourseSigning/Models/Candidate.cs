using System.ComponentModel.DataAnnotations;

namespace CourseSigning.Models
{
    public class Candidate
    {
        [Required(ErrorMessage = "E-mail is required.")]
        public string? EMail { get; set; } = String.Empty;
        [Required(ErrorMessage = "Firstname is required.")]
        public string? FirstName { get; set; } = String.Empty;
        [Required(ErrorMessage ="LastName is required")]
        public string? LastName { get; set; } = String.Empty;
        public string? FullName => $"{FirstName} {LastName?.ToUpper()}";
        [Required(ErrorMessage ="Age is required")]
        public int? Age { get; set; } = 0;
        public string? SelectedCourse { get; set; } = String.Empty;
        public DateTime ApplyTime { get; set; }


        public Candidate()
        {
            ApplyTime = DateTime.Now;
        }
    }
}