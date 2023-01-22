using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CommerceApp.Pages
{
    public class FormModel : PageModel
    {
        private readonly ILogger<FormModel> _logger;

        public FormModel(ILogger<FormModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}