using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace _13_FirstWebApp.Pages
{
    public class PersonModel : PageModel
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public IList<string> Mails { get; set; }
        public string Image { get; set; }

        public void OnGet([FromRoute] int id, string? image)
        {
            if (id == 5)
            {
                this.Firstname = "Tobias";
                this.Lastname = "Zarzer";
                this.Mails = new List<string>();
                this.Mails.Add("tobias.zarzer@josephinum.at");
                this.Mails.Add("tobias@zarzer.at");
                this.Image = "unternehmen_teaser.jpg";
            }
            else
            {
                this.Firstname = "Stefan";
                this.Lastname = "Schwödiauer";
                this.Mails = new List<string>();
                this.Mails.Add("stefan.schwödiauer@josephinum.at");
                this.Mails.Add("stefan@schwödiauer.at");
                this.Image = "Arnold_Schwarzenegger_1974.jpg";
            }


            if (Image != null)
            {
                this.Image = image;
            }
        }
    }
}
