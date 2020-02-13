using System;
using System.Collections.Generic;

namespace less_14_3
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Neighbor> floorNeihgbors = new List<Neighbor>();
            Neighbor ivan = new Neighbor
            {
                FullName = "Ivanov Ivan",
                FlatNumber = 101,
                PhoneNumber = "+375 17 5552221"
            };
            Neighbor petr = new Neighbor
            {
                FullName = "Petrov Petr",
                FlatNumber = 102,
                PhoneNumber = "+375 17 5552222"
            };
            Neighbor fedor = new Neighbor
            {
                FullName = "Fedorov Fedor",
                FlatNumber = 103,
                PhoneNumber = "+375 17 5552223"
            };
            floorNeihgbors.Sort();

            floorNeihgbors.Add(ivan);
            floorNeihgbors.Add(petr);
            floorNeihgbors.Add(fedor);

            while (true)
            {
                Console.WriteLine("Введите номер квартиры на вашем этаже (от 101 до 103х):");
                string flatNum=Console.ReadLine();
                Neighbor found = floorNeihgbors.Find(item => item.FlatNumber.ToString() == flatNum);
                if (found != null)
                {
                    Console.WriteLine(
                     $"Номер телефона соседа из квартиры {found.FlatNumber.ToString()}: {found.PhoneNumber}");
                    break;
                }
                else Console.WriteLine("Такого соседа нет, будь внимательнее!");
            }
            Console.ReadKey();
        }
    }
}
