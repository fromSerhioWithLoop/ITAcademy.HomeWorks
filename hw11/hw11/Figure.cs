using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw11
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
}
