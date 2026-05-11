using EmployeeManagementSystem.Models;

namespace EmployeeManagementSystem.Services
{
    public interface IEmployeeService
    {
        Task<(List<Employee> Employees, int TotalCount)> GetEmployees(
            string? searchTerm,
            int? departmentId,
            int? employeeTypeId,
            int pageNumber,
            int pageSize);

        Task<Employee?> GetEmployeeByIdAsync(int id);

        Task CreateEmployeeAsync(Employee employee);

        Task UpdateEmployeeAsync(Employee employee);

        Task DeleteEmployeeAsync(int id);

        Task<List<Department>> GetDepartmentsAsync();

        Task<List<EmployeeType>> GetEmployeeTypesAsync();

        Task<List<Designation>> GetDesignationsByDepartmentAsync(int departmentId);
    }
}