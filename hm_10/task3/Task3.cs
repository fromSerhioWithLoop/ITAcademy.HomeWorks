using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hm10_task3
{
    class Program
    {
        static void Main(string[] args)
        {
            //            Regular Ball Super Ball

            //Create a class Ball.

            //Ball objects should accept one argument for "ball type" when instantiated.

            //If no arguments are given, ball objects should instantiate with a "ball type" of "regular."

            //ball1 = new Ball();
            //        ball2 = new Ball("super");

            //        ball1.ballType     //=> "regular"
            //        ball2.ballType     //=> "super"
        }
    }



    public class Ball
    {
        public string ballType { get; set; }

        public Ball(string ballType)
        {
            this.ballType = ballType;
        }
        public Ball()
        {
            this.ballType = "regular";
        }

    }
}
