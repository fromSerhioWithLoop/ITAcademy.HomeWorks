using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_12
{
    class Program
    {
        static void Main(string[] args)
        {
            int NumberFigures = 5; // требуемое колво фигур(если 5 - будет 2 квадрата 2 круга и 1 треугольник)
            Engine e = new Engine();
            Object[] arr = e.GetMass(NumberFigures);
            int i;
            for (i = 0; i < NumberFigures; i++)
            {
                Figure figure = new Figure();
                figure = (Figure)arr[i];
                Console.WriteLine($"\n   {i + 1}\t This is {figure.Name}. CLR type is {figure.FigType}. Square is {figure.Area}");
            }
            Console.WriteLine("\n\t Press any key to exit.");
            Console.ReadKey();

        }
    }
}
