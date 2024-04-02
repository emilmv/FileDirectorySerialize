using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace FileDirectorySerialize.Entities
{
    public class Department
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public List<Employee> Employees { get; set; }

        void AddEmployee(Employee employee)
        {

        }
        public Employee GetEmployeeById(int id)
        {
            Employee foundEmployee = Employees.Find(e=>e.Id==id);
            if (foundEmployee == null)
            {
                Console.WriteLine("EMPLOYEE NOT FOUND");
            }
            return foundEmployee;
            
        }
       public void RemoveEmployee(int id)
        {
            Employee foundEmployee=Employees.Find(e=>e.Id==id);
            if (foundEmployee == null)
            {
                Console.WriteLine("EMPLOYEE NOT FOUND");
            }
            else Employees.Remove(foundEmployee);
        }
    }
}
