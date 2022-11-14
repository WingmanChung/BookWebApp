using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BookWebApp.Pages
{
    public class TrendingModel : PageModel
    {
        private readonly ILogger<TrendingModel> _logger;

        public TrendingModel(ILogger<TrendingModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}