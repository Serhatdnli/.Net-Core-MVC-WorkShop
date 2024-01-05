namespace Basics.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string FullName => $"{FirstName} {LastName.ToUpper()}";
        public int Age { get; set; } = 0;

        public Employee(int id, string name, string lastname, int age)
        {
            Id = id;
            FirstName = name;
            LastName = lastname;
            Age = age;
        }

    }
}