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
        private readonly LoginModelDBContext _loginModel;
        public ProtectedFormModel(LoginModelDBContext context)
        {
            _loginModel = context;
        }
        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public LoginModel LoginModel { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            string redirectURL = HttpContext.Request.Query["returnURL"].ToString();

            if (!ModelState.IsValid)
            {
                return Page();
            }

            _loginModel.LoginModels.Add(LoginModel);
            await _loginModel.SaveChangesAsync();

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