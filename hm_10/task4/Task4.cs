using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            //            Write a class Block that creates a block(Duh..)

            //##Requirements

            //The constructor should take an array as an argument, this will contain 3 integers
            //of the form[width, length, height] from which the Block should be created.

            //Define these methods:

            //`GetWidth()` return the width of the `Block`

            //`GetLength()` return the length of the `Block`

            //`GetHeight()` return the height of the `Block`

            //`GetVolume()` return the volume of the `Block`

            //`GetSurfaceArea()` return the surface area of the `Block`
        }
    }

    class Block
    {
        public int Width { get; set; }
        public int Lenght { get; set; }
        public int Height { get; set; }

        public Block(int[] arr)
        {
            Width = arr[0];
            Height = arr[2];
            Lenght = arr[1];
        }

        public int GetWidth() { return Width; }
        public int GetHeight() { return Height; }
        public int GetLength() { return Lenght; }
        public int GetVolume() { return Width * Lenght * Height; }
        public int GetSurfaceArea() { return (Height * Lenght + Height * Width + Lenght * Width) * 2; }

    }

}
