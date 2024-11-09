using Features.Models;

namespace Features.Services;

public static class EmployeeService
{
    // Reusable employee data
    private static List<Employee> GetEmployees()
    {
        return
        [
            new Employee { Name = "Alice", Department = "HR", Salary = 50000 },
            new Employee { Name = "Bob", Department = "IT", Salary = 70000 },
            new Employee { Name = "Charlie", Department = "HR", Salary = 55000 },
            new Employee { Name = "David", Department = "IT", Salary = 80000 },
            new Employee { Name = "Eve", Department = "Finance", Salary = 65000 }
        ];
    }

    // Group employees by department and return as a dictionary
    private static Dictionary<string, List<Employee>> GetGroupedByDepartment()
    {
        return GetEmployees()
            .GroupBy(emp => emp.Department)
            .ToDictionary(group => group.Key, group => group.ToList());
    }

    // Calculate total salary by department and return as a list of department-salary pairs
    private static List<(string Department, int TotalSalary)> GetSalaryByDepartment()
    {
        return GetEmployees()
            .GroupBy(emp => emp.Department)
            .Select(g => (Department: g.Key, TotalSalary: g.Sum(emp => emp.Salary)))
            .OrderByDescending(x => x.TotalSalary)
            .ToList();
    }

    // Method to print grouped data
    public static void PrintGroupedByDepartment()
    {
        var groupedByDepartment = GetGroupedByDepartment();
        foreach (var (department, employees) in groupedByDepartment)
        {
            Console.WriteLine($"Department: {department}");
            foreach (var employee in employees)
                Console.WriteLine($"  Name: {employee.Name}, Salary: {employee.Salary}");
        }
    }

    // Method to print salary by department
    public static void PrintSalaryByDepartment()
    {
        var salaryByDepartment = GetSalaryByDepartment();
        foreach (var (department, totalSalary) in salaryByDepartment)
            Console.WriteLine($"Department: {department}, Total Salary: {totalSalary}");
    }
}