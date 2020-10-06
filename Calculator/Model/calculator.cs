using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Calculator.Attribute;

namespace Calculator.Model
{
    public class calculator
    {

        public double FirstOperand { get; set; }

        public double SecondOperand { get; set; }
        
        public string Operand { get; set; }
    }
}
