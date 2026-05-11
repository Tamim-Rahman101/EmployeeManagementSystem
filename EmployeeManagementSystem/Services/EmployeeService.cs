using EmployeeManagementSystem.Data;
using EmployeeManagementSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagementSystem.Services
{
    public class EmployeeService
    {
        private readonly EmployeeDbContext _context;
        public EmployeeService(EmployeeDbContext context)
        {
            _context = context;
        }

        public async Task<(List<Employee> Employees, int TotalCount)> GetEmployees(
            string? searchTerm,
            int? departmentId,
            int? employeeTypeId,
            int pageNumber,
            int pageSize)
        {
            // Include is used to eagerly load related properties (Department, Designation, EmployeeType)
            // in a single query to improve performance by reducing the number of database round-trips.
            // It tells EF Core to execute JOIN immediately so that when the employee is loaded,
            // their associated properties (Department, Designation, EmployeeType) are also populated.

            // AsQueryable prepares the query to which we can apply filters (Where) and pagination (Skip, Take).
            var query = _context.Employees
                .Include(e => e.Department)
                .Include(e => e.Designation)
                .Include(e => e.EmployeeType)
                .AsQueryable();
            if (!string.IsNullOrWhiteSpace(searchTerm))
            {
                query = query.Where(e => e.FullName.Contains(searchTerm));
            }
            if (departmentId.HasValue && departmentId.Value > 0)
            {
                query = query.Where(e => e.DepartmentId == departmentId.Value);
            }
            if (employeeTypeId.HasValue && employeeTypeId.Value > 0)
            {
                query = query.Where(e => e.EmployeeTypeId == employeeTypeId.Value);
            }

            // CountAsync executes the query to get the total count of employees matching the filters,
            var totalCount = await query.CountAsync();

            // Skip specifies the records to skip, Take specifies the next records to retrieve for the current page.
            
            // AsNoTracking improves performance by telling EF Core not to track the retrieved entities in the change tracker,
            // which is beneficial for read-only scenarios where we don't need to update the entities after retrieval.
            
            // ToListAsync executes the query and retrieves the list of employees for the current page.
            var employees = await query
                .Skip((pageNumber - 1) * pageSize)
                .Take(pageSize)
                .AsNoTracking()
                .ToListAsync();
            return (employees, totalCount);
        }
        public async Task<Employee?> GetEmployeeByIdAsync(int id)
        {
            // FirstOrDefaultAsync retrieves first employee matching the specified id or returns null if no match is found.
            return await _context.Employees
                .Include(e => e.Department)
                .Include(e => e.Designation)
                .Include(e => e.EmployeeType)
                .AsNoTracking()
                .FirstOrDefaultAsync(e => e.Id == id);
        }
        public async Task CreateEmployeeAsync(Employee employee)
        {
            _context.Employees.Add(employee);
            await _context.SaveChangesAsync();
        }
        public async Task UpdateEmployeeAsync(Employee employee)
        {
            // it tells EF Core to update the properties of employee entity only, while ignoring the changes of related
            // properties (Department, Designation, EmployeeType) to prevent unintended updates to related entities
            _context.Entry(employee).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
        public async Task DeleteEmployeeAsync(int id)
        {
            var employee = await GetEmployeeByIdAsync(id);
            if (employee != null)
            {
                _context.Employees.Remove(employee);
                await _context.SaveChangesAsync();
            }
        }

        // helper methods to get dropdown data
        public async Task<List<Department>> GetDepartmentsAsync()
        {
            return await _context.Departments.AsNoTracking().ToListAsync();
        }
        public async Task<List<EmployeeType>> GetEmployeeTypesAsync()
        {
            return await _context.EmployeeTypes.AsNoTracking().ToListAsync();
        }
        public async Task<List<Designation>> GetDesignationsByDepartmentAsync(int departmentId)
        {
            return await _context.Designations
                .Where(d => d.DepartmentId == departmentId)
                .AsNoTracking()
                .ToListAsync();
        }

    }
}
