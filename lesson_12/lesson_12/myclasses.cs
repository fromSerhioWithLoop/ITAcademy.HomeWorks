using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_12
{
    class Figure
    {
        public string Name { get; set; } = "noName";
        public int Area { get; set; }
        public object FigType { get; set; }


        public virtual int FigureArea()
        {
            return 0;
        }


    }
    class Square : Figure
    {
        public int SideA { get; set; } = 0;

        public override int FigureArea()
        {
            return SideA * SideA;
        }
    }
    class Rectangle : Figure
    {
        public int SideA { get; set; } = 0;
        public int SideB { get; set; } = 0;

        public override int FigureArea()
        {

            return Area = SideA * SideB;
        }
    }

    class Triangle : Figure
    {
        public int BaseA { get; set; } = 0;
        public int Height { get; set; } = 0;

        public override int FigureArea()
        {
            return Area = BaseA * Height / 2;
        }
    }

    class Circle : Figure
    {
        const double Pi = 3.1416;
        public int Radius { get; set; } = 0;

        public override int FigureArea()
        {
            return Area = (int)(Pi * Radius * Radius);

        }

    }

    public class Engine
    {
        public Object[] GetMass(int NumberOfFigures)
        {
            Figure[] figure = new Figure[NumberOfFigures];
            int count = 0;
            int figuresTypesCount = 3;
            Random rand = new Random();

            while (count < NumberOfFigures)
            {

                if (count % figuresTypesCount == 0)
                {
                    Square square = new Square() { SideA = rand.Next(10) };
                    Figure fig = new Figure
                    {
                        Name = "Square",
                        Area = square.FigureArea(),
                        FigType = square.GetType()
                    };
                    figure[count] = fig;
                }
                else if (count % figuresTypesCount == 2)
                {
                    Triangle triangle = new Triangle() { BaseA = rand.Next(10), Height = rand.Next(10) };
                    Figure fig = new Figure
                    {
                        Name = "Triangle",
                        Area = triangle.FigureArea(),
                        FigType = triangle.GetType()
                    };
                    figure[count] = fig;
                }
                else if (count % figuresTypesCount == 1)
                {
                    Circle circle = new Circle() { Radius = rand.Next(10) };
                    Figure fig = new Figure
                    {
                        Name = "Circle",
                        Area = circle.FigureArea(),
                        FigType = circle.GetType()
                    };
                    figure[count] = fig;
                }
                count++;
            }
            return figure;
        }


    }
}
