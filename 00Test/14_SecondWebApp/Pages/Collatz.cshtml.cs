using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace _14_SecondWebApp.Pages
{
    public class CollatzModel : PageModel
    {
        public void OnGet()
        {
        }
        [HttpPost]
        public IActionResult OnPostCollatz(int zahl)
        {
            List<int> result = new List<int>();
            result.Add(zahl);
            while (zahl>1)
            {
                if (zahl % 2 == 0)
                {
                    zahl = zahl / 2;
                    result.Add(zahl);
                }
                else
                {
                    zahl = 3 * zahl + 1;
                    result.Add(zahl);
                }
            }
            return RedirectToPage("Anzeigeelement", new
            {
                result = result
            });
        }
    }
}


