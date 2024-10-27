using System.ComponentModel.DataAnnotations;

namespace EmployeeData.EFDAL
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string Designation { get; set; }
    }
}
