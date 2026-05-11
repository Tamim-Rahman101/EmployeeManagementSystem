namespace EmployeeManagementSystem.Models
{
    public class EmployeeType
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public bool IsActive { get; set; }
        public List<Employee>? Employees { get; set; }
    }
}
