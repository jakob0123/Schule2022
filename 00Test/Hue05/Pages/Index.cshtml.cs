using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Hue05.Pages
{
    public class IndexModel : PageModel
    {
        public int zeit { get; set; }
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
        [HttpPost]
        public IActionResult OnPostAufstiegszeit(int entferung, int abstieg,int aufstieg)
        {
            int zeit;
            if (abstieg ==null&& aufstieg == null)
            {
                zeit = (entferung / 4)*60;   
            }
            else if(abstieg ==null&&aufstieg!=null)
            {
                zeit = (entferung/4)+(aufstieg/2);
            }
            else if (aufstieg == null && abstieg != null)
            {
                zeit = (entferung / 4) + (abstieg / 2);
            }
            else
            {
                zeit = (entferung/4)+(aufstieg / 2)+(abstieg/2);
            }
            return RedirectToPage("Index", new
            {
                zeit = zeit
            });
        }
    }
}