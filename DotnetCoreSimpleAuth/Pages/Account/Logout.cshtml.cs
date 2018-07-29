using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace DotnetCoreSimpleAuth.Pages.Account
{
    public class LogoutModel : PageModel
    {
        private readonly ILogger<LogoutModel> logger;

        public LogoutModel(ILogger<LogoutModel> logger)
        {
            this.logger = logger;
        }

        public async Task<IActionResult> OnGetAsync()
        {
            logger.LogInformation($"User {User.Identity.Name} logged out at {DateTime.UtcNow}.");

            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return Redirect("/Account/SignedOut");
        }
    }
}