using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw11
{
    public class Engine
    {
        public Object[] GetMass(int NumberOfFigures)
        {
            Figure[] figure = new Figure[NumberOfFigures];
            int count = 0;
            Random rand = new Random();

            while (count < NumberOfFigures)
            {

                if (count % NumberOfFigures == 0)
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
                else if (count % NumberOfFigures == 1)
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
                else if (count % NumberOfFigures == 2)
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
