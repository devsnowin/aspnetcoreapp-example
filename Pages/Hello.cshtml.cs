using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace aspnetcoreapp_example.Pages;

public class HelloModel : PageModel
{
    private readonly ILogger<HelloModel> _logger;

    public HelloModel(ILogger<HelloModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {

    }
}
