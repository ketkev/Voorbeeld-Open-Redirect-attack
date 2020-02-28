using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace OpenRedirect
{
    public class ProtectedFormModel : PageModel
    {

        public IActionResult OnGet()
        {
            return Page();
        }

        public IActionResult OnPost()
        {
            string redirectURL = HttpContext.Request.Query["returnURL"].ToString();

            if (Url.IsLocalUrl(redirectURL))
            {
                return Redirect(redirectURL);
            }
            else
            {
                return RedirectToPage("./Index");
            }
        }
    }
}