using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Hue05.Pages
{
    public class AnzeigeelementModel : PageModel
    {
        public float zeit { get; set; }
        public float zeitmin { get; set; }
        public void OnGet(float zeit)
        {
            this.zeit = zeit;
            this.zeitmin = zeit*60;
        }
    }
}
