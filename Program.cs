using System;
using System.Text.RegularExpressions;


namespace DZ1

{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"^[\p{L}]+$";
            while (true)
            {
                Console.WriteLine("Введите Ваше имя, пожалуйста");
                string name = Console.ReadLine();
                if (Regex.IsMatch(name, pattern, RegexOptions.IgnoreCase))
                {
                    Console.WriteLine($"Привет, {name}, сегодня, {DateTime.Now.ToShortDateString()} ! ");
                    break;
                }
                else
                {
                    Console.WriteLine("Вы ввели некорректное имя!");

                }
            }  
        }
    }
}
