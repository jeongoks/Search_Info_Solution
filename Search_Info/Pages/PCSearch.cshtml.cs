using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Search_Info.Pages
{
    public class PCSearchModel : PageModel
    {
        public void OnGet()
        {
        }

        /// <summary>
        /// Returning to a specific page with the Post method in form.
        /// </summary>
        /// <returns></returns>
        public IActionResult OnPost()
        {
            return RedirectToPage("/Index");
        }
    }
}
