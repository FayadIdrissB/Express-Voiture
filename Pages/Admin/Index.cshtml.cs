using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Express_Voiture.Pages.Admin
{
	public class IndexModel : PageModel
    {
        public IActionResult OnGet()
        {
            Console.WriteLine(HttpContext.User);
            if (HttpContext.User.Identity.IsAuthenticated)
            {
                return Redirect("/Admin/Voitures");
            }
            return Page();
        }

        public async Task<IActionResult> OnPost(string username, string password, string ReturnUrl)
        {
            if (username == "admin")
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, username)
                };
                var claimsIdentity = new ClaimsIdentity(claims, "Login");
                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new
                ClaimsPrincipal(claimsIdentity));
                return Redirect(ReturnUrl == null ? "/Admin/Voitures" : ReturnUrl);
            }
            return Page();
        }


        public async Task<IActionResult> OnGetLogout()
        {
            await HttpContext.SignOutAsync();
            return Redirect("/Admin");
        }
    }
}
