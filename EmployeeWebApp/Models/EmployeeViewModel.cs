namespace EmployeeWebApp.Models
{
    public class EmployeeViewModel
    {
        public List<EmployeeModel> Employees { get; set; }
    }

    public class EmployeeModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string Designation { get; set; }
    }
}
