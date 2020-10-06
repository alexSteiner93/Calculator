using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Calculator.Model;

namespace Calculator.Service
{
    public interface ICalculatorService
    {
        public double calculate(calculator Calculator);

    }
    public class CalculatorService : ICalculatorService
    {

        public double calculate(calculator Calculator)
        {
            switch (Calculator.Operand)
            {
                case "-":
                    return Calculator.FirstOperand - Calculator.SecondOperand;
                case "+":
                    return Calculator.FirstOperand + Calculator.SecondOperand;
                case "/":
                    return Calculator.FirstOperand / Calculator.SecondOperand;
                case "*":
                    return Calculator.FirstOperand * Calculator.SecondOperand;
                case "%":
                    return Calculator.FirstOperand % Calculator.SecondOperand;
                
                default: return 0.0;
            }

        }
    }
}
