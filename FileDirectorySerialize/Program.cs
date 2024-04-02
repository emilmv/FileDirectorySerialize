using FileDirectorySerialize.Entities;

namespace FileDirectorySerialize
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "C:\\Users\\user\\Desktop\\FileDirectorySerialize\\Files\\Database.json";
            DirectoryInfo directoryInfo = new(path);
            if (!directoryInfo.Exists) directoryInfo.Create();

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
                        IdInput:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.BackgroundColor = ConsoleColor.DarkBlue;
                        Console.WriteLine("PLEASE TYPE EMPLOYEE ID");
                        Console.ResetColor();
                        string? idInput = Console.ReadLine();
                        if (string.IsNullOrEmpty(idInput)||!idInput.Any(char.IsDigit))
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.BackgroundColor = ConsoleColor.DarkBlue;
                            Console.WriteLine("ID VALUE CANNOT BE EMPTY AND HAS TO HAVE AT LEAST ONE NUMBER");
                            Console.WriteLine();
                            Console.ResetColor();
                            goto IdInput;
                        }



                        Employee employee = new();
                        employee.Id = 1;
                        break;
                    case 2:

                        break;
                    case 3:

                        break;
                    case 4: return;
                }
            }
        }
    }
}
