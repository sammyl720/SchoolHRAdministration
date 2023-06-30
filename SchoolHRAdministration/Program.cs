using HRAdmininstrationAPI;
using SchoolHRAdministration;
// See https://aka.ms/new-console-template for more information
decimal totalSalaries = 0;
List<IEmployee> employees = new List<IEmployee>();

SeedData(employees);

//foreach (var employee in employees)
//{
//    totalSalaries += employee.Salary;
//}

//Console.WriteLine($"Total Annual Salaries (including bonus): {totalSalaries}");
Console.WriteLine($"Total Annual Salaries (including bonus): {employees.Sum(employee => employee.Salary)}");

static void SeedData(List<IEmployee> employees)
{
    employees.Add(EmployeeFactory.GetEmployeeInstance(EmployeeType.Teacher, 1, "Bob", "Fisher", 40000));
    employees.Add(EmployeeFactory.GetEmployeeInstance(EmployeeType.Teacher, 2, "Jenny", "Thomas", 40000));
    employees.Add(EmployeeFactory.GetEmployeeInstance(EmployeeType.HeadOfDepartment, 3, "Brenda", "Mullins", 50000));
    employees.Add(EmployeeFactory.GetEmployeeInstance(EmployeeType.DeputyHeadMaster, 4, "Devlin", "Brown", 60000));
    employees.Add(EmployeeFactory.GetEmployeeInstance(EmployeeType.HeadMaster, 5, "Damien", "Jones", 80000));
}