using HRAdmininstrationAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolHRAdministration
{
    public static class EmployeeFactory
    {
        public static IEmployee GetEmployeeInstance(EmployeeType employeeType, int id, string firstName, string lastName, decimal salary)
        {
            var employee =  employeeType switch
            {
                EmployeeType.Teacher => FactoryPattern<IEmployee, Teacher>.GetInstance(),
                EmployeeType.HeadOfDepartment => FactoryPattern<IEmployee, HeadOfDepartment>.GetInstance(),
                EmployeeType.DeputyHeadMaster => FactoryPattern<IEmployee, DeputyHeadMaster>.GetInstance(),
                EmployeeType.HeadMaster => FactoryPattern<IEmployee, HeadMaster>.GetInstance(),
                _ => FactoryPattern<IEmployee, EmployeeBase>.GetInstance()
            };

            employee.Id= id;
            employee.FirstName= firstName;
            employee.LastName= lastName;
            employee.Salary= salary;
            return employee;
        }
    }
}
