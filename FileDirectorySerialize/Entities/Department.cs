using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace FileDirectorySerialize.Entities
{
    internal class Department
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public List<Employee> Employees { get; set; }

        void AddEmployee(Employee employee)
        {

        }
        void GetEmployeeById(int id)
        {

        }
        void RemoveEmployee(int id)
        {

        }
    }
}
