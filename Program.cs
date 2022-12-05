using System;

namespace interfaceCalc
{
    class Program
    {
        static void Main(string[] args)
            
        {
            var BasicCalc = new Calculator();
            var ScientificCalc = new Calculator();
            BasicCalc.GetNum();

            Console.WriteLine("Calculator");

            again:
            Console.WriteLine("Select a option : ");
            Console.WriteLine("1.ADD   2.SUB   3.MUL   4.DIV   5.EXP_OPERATION   6.LOG_OPERATION   7.MATRIX");
            int choice = int.Parse(Console.ReadLine());


            switch (choice)
            {
                case 1:
                    BasicCalc.Addition();
                    goto again;
                    break;
                
                case 2:
                    BasicCalc.Subtrtaction();
                    goto again;
                    break;

                case 3:
                    BasicCalc.Multiplication();
                    goto again;
                    break;

                case 4:
                    BasicCalc.Division();
                    goto again;
                    break;

                case 5:
                    ScientificCalc.Exponential();
                    goto again;
                    break;

                case 6:
                    ScientificCalc.LogOperation();
                    goto again;
                    break;

                case 7:
                    ScientificCalc.MatrixOperation();
                    goto again;
                    break;

                default:
                    Console.WriteLine("Invalid Option!!!!");
                    goto again;
                    break;
            }
        }
    }
}
