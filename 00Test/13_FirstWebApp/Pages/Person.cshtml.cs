using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace _13_FirstWebApp.Pages
{
    public class PersonModel : PageModel
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public void OnGet()
        {
            this.Firstname = "Tobias";
            this.Lastname = "Zarzer";
        }
    }
}
