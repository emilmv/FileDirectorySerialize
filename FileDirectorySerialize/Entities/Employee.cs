using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileDirectorySerialize.Entities
{
    internal class Employee
    {
        public int Id { get; set; } 
        public string? Name { get; set; }
        public double Salary { get; set; }

        void ShowInfo()
        {
            Console.WriteLine($"ID: {Id} | NAME: {Name} | SALARY: {Salary} ");
        }
    }
}
