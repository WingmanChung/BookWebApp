using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BookWebApp.Pages
{
    public class NewModel : PageModel
    {
        private readonly ILogger<NewModel> _logger;

        public NewModel(ILogger<NewModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}