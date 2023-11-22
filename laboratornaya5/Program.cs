using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laboratornaya5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double A = 0;
            double B = 0;

            while (true)
            {
                Console.WriteLine("\nМеню:");
                Console.WriteLine("1. Ввести А");
                Console.WriteLine("2. Ввести В");
                Console.WriteLine("3. Выполнить операцию «+»");
                Console.WriteLine("4. Выполнить операцию «-»");
                Console.WriteLine("5. Выполнить операцию «*»");
                Console.WriteLine("6. Выполнить операцию «/»");
                Console.WriteLine("7. Выход");

                Console.Write("\nВыберите действие: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "5":
                        Console.WriteLine("========Результат: " + (A * B));
                        break;
                    default:
                        Console.WriteLine("Неверный выбор. Пожалуйста, попробуйте еще раз.");
                        break;
                }
            }
        }
    }
}
