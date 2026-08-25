using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace subtask_3.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;
    private readonly IConfiguration _configuration;
    
    public string WelcomeMessage { get; set; }

    public IndexModel(ILogger<IndexModel> logger, IConfiguration configuration)
    {
        _logger = logger;
        _configuration = configuration;
    }

    public void OnGet()
    {
        WelcomeMessage = _configuration["AppSettings:WelcomeMessage"];
    }
}