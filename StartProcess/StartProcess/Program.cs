using System;
using System.Diagnostics;
namespace StartProcess
{
    class Program
    {
        static void Main(string[] args)
        {
            int chose;
            while (true)
            {
                Console.WriteLine("Выберите приложение для запуска:\n");
                Console.WriteLine("1. Блокнот");
                Console.WriteLine("2. Калькулятор");
                Console.WriteLine("3. Paint");
                Console.WriteLine("4. Visual Studio Code");
                Console.WriteLine("5. Выход");
                chose = Convert.ToInt32(Console.ReadLine());
                if (chose == 5)
                {
                    break;
                }
                else
                {
                    Console.Clear();
                    switch (chose)
                    {
                        case 1:
                            Process.Start($@"C:\Windows\system32\notepad.exe");
                            break;
                        case 2:
                            Process.Start($@"C:\Windows\system32\calc.exe");
                            break;
                        case 3:
                            Process.Start($@"C:\Windows\system32\mspaint.exe");
                            break;
                        case 4:
                            Process.Start($@"C:\Users\arata\AppData\Local\Programs\Microsoft VS Code\Code.exe");
                            break;
                    }
                }
            }
        }
    }
}
