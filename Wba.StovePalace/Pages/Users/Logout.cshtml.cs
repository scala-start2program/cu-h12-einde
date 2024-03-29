using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Wba.StovePalace.Helpers;

namespace Wba.StovePalace.Pages.Users
{
    public class LogoutModel : PageModel
    {
        public Availability Availability { get; set; }

        public void OnGet()
        {
            CookieOptions cookieOptions = new CookieOptions();
            cookieOptions.Expires = new DateTimeOffset(DateTime.Now.AddDays(-1));
            HttpContext.Response.Cookies.Append("UserId", "", cookieOptions);
            Response.Redirect("../Stoves/Index");

        }
    }
}
