using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Calculator.Model;
using Calculator.Service;

namespace Calculator.Pages
{
    public class CalculatorModel : PageModel
    {
        public calculator Calculator { get; set; }

        public double Result { get; set; }

        private ICalculatorService _calcutaorService;

        public CalculatorModel(ICalculatorService service)
        {
            this._calcutaorService = service;
        }
        public void OnGetCalculatorParam(calculator Calculator)
        {
            this.Calculator = Calculator;
            Result = _calcutaorService.calculate(this.Calculator);
        }
        public IActionResult OnPost()
        {
            return RedirectToPage("./Index");
        }
    }
}