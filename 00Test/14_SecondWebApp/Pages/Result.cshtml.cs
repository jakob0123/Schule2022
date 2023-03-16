using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace _14_SecondWebApp.Pages
{
    public class ResultModel : PageModel
    {
        public double Result { get; set; }
        public string Calculation { get; set; }
        public string Seitenelment { get; set; }
        public void OnGet(double result, string calculation,string seitenelment)
        {
            Result = result;
            Calculation = calculation;
            Seitenelment = seitenelment;
        }
    }
}
