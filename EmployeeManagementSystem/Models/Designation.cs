namespace EmployeeManagementSystem.Models
{
    public class Designation
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int? DepartmentId { get; set; }
        public Department? Department { get; set; }
        public bool IsActive { get; set; }
    }
}
