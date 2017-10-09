using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                InputData inputData = new InputData();
                CalculatorOperation calculatorOperation = new CalculatorOperation();

                double firstNumber, secondNumber;
                string operation;
                firstNumber = inputData.ConvertDatatoNumberic(Console.ReadLine());
                secondNumber = inputData.ConvertDatatoNumberic(Console.ReadLine());
                operation = Console.ReadLine();

                double result = calculatorOperation.calculate(operation, firstNumber, secondNumber);
                Console.WriteLine(result);
            

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }

            Console.ReadLine();


        }
    }
}
