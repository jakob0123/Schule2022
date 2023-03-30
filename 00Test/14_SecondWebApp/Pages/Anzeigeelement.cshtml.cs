using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace _14_SecondWebApp.Pages
{
    public class AnzeigeelementModel : PageModel
    {
        public List<int>? Result { get; set; }
        public void OnGet(List<int> result)
        {
            this.Result = result;
        }
    }
}
