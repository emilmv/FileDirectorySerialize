using FileDirectorySerialize.Entities;
using Newtonsoft.Json;
using System.Collections.Immutable;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace FileDirectorySerialize
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string path = "C:\\Users\\user\\Desktop\\FileDirectorySerialize\\FileDirectorySerialize\\Files";
            Directory.SetCurrentDirectory(path);
            DirectoryInfo directoryInfo = new(path);
            if (!directoryInfo.Exists) directoryInfo.Create();
            Department Finance = new();
            Finance.Name = "FINANCE DEPARTMENT";
            Finance.Employees = new();
            Department HR = new();
            HR.Name = "HR DEPARTMENT";
            HR.Employees = new();
            Department BusinessDevelopment = new();
            BusinessDevelopment.Name = "BUSINESS DEVELOPMENT DEPARTMENT";
            BusinessDevelopment.Employees = new();
            Department Administrative = new();
            Administrative.Name = "ADMINISTRATIVE DEPARTMENT";
            Administrative.Employees = new();
            Department Procurement = new();
            Procurement.Name = "PROCUREMENT DEPARTMENT";
            Procurement.Employees = new();
            Department QA = new();
            QA.Name = "QUALITY ASSURANCE DEPARTMENT";
            QA.Employees = new();
            Department Legal = new();
            Legal.Name = "LEGAL DEPARTMENT";
            Legal.Employees = new();
            List<Department> Departments = new();
            Departments.Add(Finance);
            Departments.Add(HR);
            Departments.Add(BusinessDevelopment);
            Departments.Add(Administrative);
            Departments.Add(Procurement);
            Departments.Add(QA);
            Departments.Add(Legal);



            while (true)
            {
            Beginning:
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("PLEASE CHOOSE AN OPERATION");
                Console.ResetColor();
                Console.WriteLine("1. ADD EMPLOYEE");
                Console.WriteLine("2. GET EMPLOYEE BY ID");
                Console.WriteLine("3. REMOVE EMPLOYEE");
                Console.WriteLine("4. QUIT");
                bool isCorrectOutput = int.TryParse(Console.ReadLine(), out int userOutput);
                if (!isCorrectOutput)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine("PLEASE CHOOSE CORRECT OPERATION");
                    Console.WriteLine();
                    Console.ResetColor();
                    goto Beginning;
                }
                switch (userOutput)
                {
                    case 1:
                        Console.Clear();
                    idInput:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("ADD EMPLOYEE");
                        Console.ResetColor();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.BackgroundColor = ConsoleColor.DarkBlue;
                        Console.WriteLine("PLEASE TYPE EMPLOYEE ID");
                        Console.WriteLine();
                        Console.ResetColor();
                        bool isCorrectId = int.TryParse(Console.ReadLine(), out int idInput);
                        if (!isCorrectId)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.BackgroundColor = ConsoleColor.DarkBlue;
                            Console.WriteLine("ID CAN ONLY CONTAIN NUMBERS");
                            Console.WriteLine();
                            Console.ResetColor();
                            goto idInput;
                        }
                    nameInput:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.BackgroundColor = ConsoleColor.DarkBlue;
                        Console.WriteLine("PLEASE TYPE EMPLOYEE NAME");
                        Console.WriteLine();
                        Console.ResetColor();
                        string? nameInput = Console.ReadLine();
                        if (string.IsNullOrEmpty(nameInput))
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.BackgroundColor = ConsoleColor.DarkBlue;
                            Console.WriteLine("NAME FIELD CANNOT BE EMPTY");
                            Console.WriteLine();
                            Console.ResetColor();
                            goto nameInput;
                        }
                    salaryInput:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.BackgroundColor = ConsoleColor.DarkBlue;
                        Console.WriteLine("PLEASE ADD EMPLOYEE'S SALARY");
                        Console.WriteLine();
                        Console.ResetColor();
                        bool isCorrectSalary = double.TryParse(Console.ReadLine(), out double salaryInput);
                        if (!isCorrectSalary)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.BackgroundColor = ConsoleColor.DarkBlue;
                            Console.WriteLine("SALARY CAN NOT CONTAIN LETTERS OR BE EMPTY");
                            Console.WriteLine();
                            Console.ResetColor();
                            goto salaryInput;
                        }
                    departmentInput:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.BackgroundColor = ConsoleColor.DarkBlue;
                        Console.WriteLine("PLEASE CHOOSE EMPLOYEES DEPARTMENT");
                        Console.ResetColor();
                        Console.WriteLine("1. FINANCE");
                        Console.WriteLine("2. HR");
                        Console.WriteLine("3. BUSINESS DEVELOPMENT");
                        Console.WriteLine("4. ADMINISTRATIVE");
                        Console.WriteLine("5. PROCUREMENT");
                        Console.WriteLine("6. QUALITY ASSURANCE");
                        Console.WriteLine("7. LEGAL");
                        bool isCorrectDepartment = int.TryParse(Console.ReadLine(), out int departmentInput);
                        Employee employee = new();
                        employee.Id = idInput;
                        employee.Name = nameInput;
                        employee.Salary = salaryInput;
                        switch (departmentInput)
                        {
                            case 1:
                                Finance.Employees.Add(employee);
                                SerializeJson(Finance);
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.BackgroundColor = ConsoleColor.DarkBlue;
                                Console.WriteLine("EMPLOYEE ADDED SUCCESSFULLY!");
                                Console.WriteLine("PRESS ANY KEY TO GO BACK");
                                Console.WriteLine();
                                Console.ResetColor();
                                Console.ReadKey();
                                break;
                            case 2:
                                HR.Employees.Add(employee);
                                SerializeJson(HR);
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.BackgroundColor = ConsoleColor.DarkBlue;
                                Console.WriteLine("EMPLOYEE ADDED SUCCESSFULLY!");
                                Console.WriteLine("PRESS ANY KEY TO GO BACK");
                                Console.WriteLine();
                                Console.ResetColor();
                                Console.ReadKey();
                                break;
                            case 3:
                                BusinessDevelopment.Employees.Add(employee);
                                SerializeJson(BusinessDevelopment);
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.BackgroundColor = ConsoleColor.DarkBlue;
                                Console.WriteLine("EMPLOYEE ADDED SUCCESSFULLY!");
                                Console.WriteLine("PRESS ANY KEY TO GO BACK");
                                Console.WriteLine();
                                Console.ResetColor();
                                Console.ReadKey();
                                break;
                            case 4:
                                Administrative.Employees.Add(employee);
                                SerializeJson(Administrative);
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.BackgroundColor = ConsoleColor.DarkBlue;
                                Console.WriteLine("EMPLOYEE ADDED SUCCESSFULLY!");
                                Console.WriteLine("PRESS ANY KEY TO GO BACK");
                                Console.WriteLine();
                                Console.ResetColor();
                                Console.ReadKey();
                                break;
                            case 5:
                                Procurement.Employees.Add(employee);
                                SerializeJson(Procurement);
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.BackgroundColor = ConsoleColor.DarkBlue;
                                Console.WriteLine("EMPLOYEE ADDED SUCCESSFULLY!");
                                Console.WriteLine("PRESS ANY KEY TO GO BACK");
                                Console.WriteLine();
                                Console.ResetColor();
                                Console.ReadKey();
                                break;
                            case 6:
                                QA.Employees.Add(employee);
                                SerializeJson(QA);
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.BackgroundColor = ConsoleColor.DarkBlue;
                                Console.WriteLine("EMPLOYEE ADDED SUCCESSFULLY!");
                                Console.WriteLine("PRESS ANY KEY TO GO BACK");
                                Console.WriteLine();
                                Console.ResetColor();
                                Console.ReadKey();
                                break;
                            case 7:
                                Legal.Employees.Add(employee);
                                SerializeJson(Legal);
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.BackgroundColor = ConsoleColor.DarkBlue;
                                Console.WriteLine("EMPLOYEE ADDED SUCCESSFULLY!");
                                Console.WriteLine("PRESS ANY KEY TO GO BACK");
                                Console.WriteLine();
                                Console.ResetColor();
                                Console.ReadKey();
                                break;
                            default:
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.BackgroundColor = ConsoleColor.DarkBlue;
                                Console.WriteLine("PLEASE CHOOSE CORRECT DEPARTMENT");
                                Console.WriteLine();
                                Console.ResetColor();
                                goto departmentInput;
                        }
                        break;

                    case 2:
                        Console.Clear();
                    userIdInput:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("GET EMPLOYEE BY ID");
                        Console.ResetColor();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.BackgroundColor = ConsoleColor.DarkBlue;
                        Console.WriteLine("PLEASE TYPE EMPLOYEE ID");
                        Console.WriteLine();
                        Console.ResetColor();
                        bool isCorrectInputId = int.TryParse(Console.ReadLine(), out int inputId);
                        if (!isCorrectInputId)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.BackgroundColor = ConsoleColor.DarkBlue;
                            Console.WriteLine("ID CAN ONLY CONTAIN NUMBERS");
                            Console.WriteLine();
                            Console.ResetColor();
                            goto userIdInput;
                        }
                        foreach (var item in DeserializeJson().Employees)
                        {
                            if (item.Id == inputId)
                            {
                                Console.WriteLine($"FOUND EMPLOYEES ON {DeserializeJson().Name}");
                                item.ShowInfo();
                            }
                            else Console.WriteLine("EMPLOYEE NOT FOUND");

                        }

                        break;
                    case 3:
                        Console.Clear();
                    userIdInput2:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("GET EMPLOYEE BY ID");
                        Console.ResetColor();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.BackgroundColor = ConsoleColor.DarkBlue;
                        Console.WriteLine("PLEASE TYPE EMPLOYEE ID");
                        Console.WriteLine();
                        Console.ResetColor();
                        bool isCorrectInputId2 = int.TryParse(Console.ReadLine(), out int inputId2);
                        if (!isCorrectInputId2)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.BackgroundColor = ConsoleColor.DarkBlue;
                            Console.WriteLine("ID CAN ONLY CONTAIN NUMBERS");
                            Console.WriteLine();
                            Console.ResetColor();
                            goto userIdInput2;
                        }
                        foreach (var item in DeserializeJson().Employees)
                        {
                            if (item.Id == inputId2)
                            {
                                DeserializeJson().RemoveEmployee(inputId2);
                                foreach(var dep in Departments)
                                {
                                    SerializeJson(dep);
                                }
                                Console.WriteLine($"EMPLOYEE - {item.Name} HAS BEEN REMOVED FROM {DeserializeJson().Name}");
                            }
                        }
                        break;
                    case 4: return;
                }
            }
        }
        static void SerializeJson(Department department)
        {
            using FileStream fs = new("C:\\Users\\user\\Desktop\\FileDirectorySerialize\\FileDirectorySerialize\\Files\\Database.json", FileMode.Create);
            string data = JsonConvert.SerializeObject(department);
            using StreamWriter sr = new StreamWriter(fs);
            sr.Write(data);
        }
        static Department DeserializeJson()
        {
            using FileStream fs = new("C:\\Users\\user\\Desktop\\FileDirectorySerialize\\FileDirectorySerialize\\Files\\Database.json", FileMode.Open);
            using StreamReader sr = new(fs);
            string data = sr.ReadToEnd();
            return JsonConvert.DeserializeObject<Department>(data);


        }
    }
}
