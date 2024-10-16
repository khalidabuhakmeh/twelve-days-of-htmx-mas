using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Htmxmas.Pages.Samples.Day_03;

public class Index : PageModel
{
    public void OnGet()
    {
        
    }

    public PartialViewResult OnGetModal()
    {
        return Partial("_Modal", this);
    }
}