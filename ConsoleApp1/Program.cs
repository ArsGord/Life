using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите своё имя");
            string name = Console.ReadLine();
            Console.WriteLine($"Привет, {name}");
            Console.WriteLine("Введите количетво дней жизни");
            string d = Console.ReadLine();
            int days = Convert.ToInt32(d);
            int years = 0, months = 0;
            while (days >= 365) {
                days -= 365;
                years++;
            };
            while (days >= 30)
            {
                days -= 30;
                months++;
            };
            Console.WriteLine($"Лет: {years}; Месяцев: {months}; Дней: {days}.");
            Console.ReadKey();
        }
    }
    // Написать программу для подсчёта возраста из количества дней, залить на гитхаб
}
