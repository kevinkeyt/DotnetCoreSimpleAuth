using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DotnetCoreSimpleAuth.Pages.Account
{
    public class AccessDeniedModel : PageModel
    {
        public AccessDeniedModel()
        {
        }
        public IActionResult OnGet()
        {
            return Page();
        }
    }
}