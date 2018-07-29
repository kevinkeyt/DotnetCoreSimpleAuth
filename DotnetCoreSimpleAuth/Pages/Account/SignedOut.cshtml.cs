using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace DotnetCoreSimpleAuth.Pages.Account
{
    public class SignedOutModel : PageModel
    {
        private readonly ILogger<SignedOutModel> logger;

        public SignedOutModel(ILogger<SignedOutModel> logger)
        {
            this.logger = logger;
        }

        public IActionResult OnGet()
        {
            if (User.Identity.IsAuthenticated)
            {
                // Redirect to home page if the user is authenticated.
                return RedirectToPage("/Index");
            }
            return Page();
        }
    }
}