using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OpenRedirect.Models;

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