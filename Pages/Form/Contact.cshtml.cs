using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc;
using aspnetcoreapp_example.Models;

namespace aspnetcoreapp_example
{
    public class ContactModel : PageModel
    {
        private readonly ILogger<ContactModel> _logger;
        public ContactModel(ILogger<ContactModel> logger)
        {
            _logger = logger;
        }
        
        [BindProperty]
        public ContactFormModel contact {get; set;}
        
        public void OnGet()
        {

        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid == false) return Page();
            return RedirectToPage("/Index", new {name = contact.name});
        }
    }

}

