namespace CourseSigning.Models
{
    public class Candidate
    {
        public string? EMail { get; set; } = String.Empty;
        public string? FirstName { get; set; } = String.Empty;
        public string? LastName { get; set; } = String.Empty;
        public string? FullName => $"{FirstName} {LastName?.ToUpper()}";
        public int? Age { get; set; } = 0;
        public string? SelectedCourse { get; set; } = String.Empty;
        public DateTime ApplyTime { get; set; }


        public Candidate()
        {
            ApplyTime = DateTime.Now;
        }
    }
}