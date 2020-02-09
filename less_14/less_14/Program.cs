using System;

namespace less_14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку:");
            string str =Console.ReadLine();
            Console.WriteLine(str.StringCutter());//cut string for a 5 simbols leght
            Console.ReadKey();
        }
    }
}
