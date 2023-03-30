using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Hue05.Pages
{
    public class IndexModel : PageModel
    {
        public float zeit { get; set; }
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
        [HttpPost]
        public IActionResult OnPostAufstiegszeit(float entferung, float abstieg, float aufstieg)
        {
            float zeit;
            zeit = (entferung / 4) + ((aufstieg / 300) / 2) + ((abstieg / 500) / 2);
            return RedirectToPage("Anzeigeelement", new
            {
                zeit = zeit
            });
        }
    }
}