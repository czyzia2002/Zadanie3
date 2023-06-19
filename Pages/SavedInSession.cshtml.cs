using FizzBuzzWeb.Forms;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;



namespace FizzBuzzWeb.Pages
{
    public class SavedInSessionModel : PageModel
    {
        public string sessionData;

        public void OnGet()
        {
            var Data = HttpContext.Session.GetString("Data");
            if (Data != null)
				sessionData = JsonConvert.DeserializeObject<string>(Data);
        }
    }
}