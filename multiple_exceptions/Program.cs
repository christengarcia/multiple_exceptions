/*
 * C# Program to Demonstrate Multiple Exceptions
 */

using System;

namespace multiple_exceptions
{
    class Excercise
    {
        static void Main(string[] args)
        {
            double Num1, Num2;
            double Result = 0.00;
            char op;

            try
            {
                Console.Write("Enter your First Number :  ");
                Num1 = double.Parse(Console.ReadLine());
                Console.Write("Enter an Operator  (+, -, * or /): ");
                op = char.Parse(Console.ReadLine());
                if (op != '+' && op != '-' &&
                    op != '*' && op != '/')
                    throw new Exception(op.ToString());
                Console.Write("Enter your Second Number :");
                Num2 = double.Parse(Console.ReadLine());
                if (op == '/')
                    if (Num2 == 0)
                        throw new DivideByZeroException("Division by zero is not allowed");
                Result = Calculator(Num1, Num2, op);
                Console.WriteLine("\n{0} {1} {2} = {3}", Num1, op, Num2, Result);
            }


        }
    }
}
