using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OpenRedirect.Models;

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