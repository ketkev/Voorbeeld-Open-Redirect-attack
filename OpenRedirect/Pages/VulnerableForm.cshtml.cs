using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace OpenRedirect
{
    public class VulnerableFormModel : PageModel
    {
        public IActionResult OnGet()
        {
            return Page();
        }

        public IActionResult OnPost()
        {
            string redirectURL = HttpContext.Request.Query["returnURL"].ToString();
            redirectURL = (redirectURL == "" ? "./Index" : redirectURL);

            return Redirect(redirectURL);
        }
    }
}