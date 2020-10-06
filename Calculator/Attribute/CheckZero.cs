using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Globalization;
using System.ComponentModel.DataAnnotations;

namespace Calculator.Attribute
{
    [AttributeUsage(AttributeTargets.Property)]
    public class CheckZero : ValidationAttribute
    {
        private string Operand {get;}
        private double Value { get; }
        public CheckZero(String operand, double Value)
        {
            this.Operand = operand;
            this.Value = Value;
        }
        public override bool IsValid(object value)
        {
            if(this.Operand.Equals("/") && Value == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }


    }
}
