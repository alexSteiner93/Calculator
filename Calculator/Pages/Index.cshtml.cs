using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Calculator.Model;
namespace Calculator.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        [BindProperty]
        public calculator Calculator { get; set; }

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
            this.Calculator = new calculator();
        }

        public void OnGet()
        {

        }
        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                return RedirectToPage("./Calculator", "CalculatorParam", this.Calculator);
            }
            else
            {
                return Page();
            }
        }
    }
}
