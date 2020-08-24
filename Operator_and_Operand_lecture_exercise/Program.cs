using System;

namespace Operator_and_Operand_lecture_exercise
{
    class Program
    {


        public static double circlearea( double r)
        {
            return Math.PI * Math.Pow(r, 2);
        }


        static void Main(string[] args)
        {
            int a = 17;
            int b = 4;
            int quotient = a / b;
            int mod = a % b;

            Console.WriteLine(quotient);
            Console.WriteLine(mod);



              
            var radius = double.Parse(Console.ReadLine());
            circlearea(radius);
            var area = circlearea(radius);
            Console.WriteLine(area);
       


        }
    }
}
