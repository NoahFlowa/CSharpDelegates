using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    class Program
    {

        delegate double Calculate(double operand1, double operand2);



        static void Main(string[] args)
        {
            // Anonymous function / method
            Calculate Multiply = delegate (double operand1, double operand2) { return operand1 * operand2; };

            Calculate operation = Add;
            DisplayAnswer(operation, 5, 7);

            DisplayAnswer(Add, 5, 7);
            DisplayAnswer(Subtract, 5, 7);
            DisplayAnswer(Multiply, 5, 7);
        }

        static double Add(double operand1, double operand2)
        {
            return operand1 + operand2;
        }

        static double Subtract(double operand1, double operand2)
        {
            return operand1 - operand2;
        }

        static void DisplayAnswer(Calculate operation, double operand1, double operand2)
        {

            Console.WriteLine($"Answer: {operation(operand1, operand2)}");
            Console.ReadKey();

        }
    }
}
