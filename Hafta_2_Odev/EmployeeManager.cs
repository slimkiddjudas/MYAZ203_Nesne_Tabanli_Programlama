using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta_2_Odev
{
    internal class EmployeeManager
    {
        private List<Employee> employees = new List<Employee>
        {
            new Employee
            {
                Id = 1,
                FirstName = "Umut",
                LastName = "Çerkezoğlu",
                Age = 19
            },
            new Employee
            {
                Id = 2,
                FirstName = "Osman",
                LastName = "Faik",
                Age = 20
            },
            new Employee
            {
                Id = 3,
                FirstName = "Zeynel",
                LastName = "Delipınar",
                Age = 19
            }
        };

        public void Add(Employee employee)
        {
            employees.Add(employee);
        }

        public void Remove(int id)
        {
            var employeeById = employees.FirstOrDefault(e => e.Id == id);
            if (employeeById != null)
            {
                employees.RemoveAt(id - 1);
            }
            else
            {
                Console.WriteLine("Bu ID'ye ait employee bulunamadı.");
            }
        }

        public void GetAll()
        {
            foreach (var employee in employees)
            {
                Console.WriteLine(employee.Id + " " + employee.FirstName + " " + employee.LastName + " " + employee.Age);
            }
        }
    }
}
