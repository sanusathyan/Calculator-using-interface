using System;
using System.Collections.Generic;
using System.Text;

namespace interfaceCalc
{
    class Calculator : IBasicCalc, IScientificCalc
    {
        private int First_num;
        private int Second_num;

        public void GetNum() 
        {
            Console.Write("Enter the first number : ");
            First_num=int.Parse(Console.ReadLine());

            Console.Write("Enter the second number : ");
            Second_num=int.Parse(Console.ReadLine());
        }

        public void Addition()
        {
            Console.WriteLine("Sum : "+( First_num + Second_num ));
        }

        public void Subtrtaction()
        {
            Console.WriteLine("Difference : " + (First_num - Second_num));
        }

        public void Multiplication()
        {
            Console.WriteLine("Product : " + (First_num * Second_num));
        }

        public void Division()
        {
            Console.WriteLine("Quotient : " + (First_num / Second_num));
        }

        public void Exponential()
        {
            Console.WriteLine("It's an exponential Operation");
        }

        public void LogOperation()
        {
            Console.WriteLine("It's an logarithm Operation");
        }

        public void MatrixOperation()
        {
            Console.WriteLine("It's an matrix Operation");
        }
    }
}
