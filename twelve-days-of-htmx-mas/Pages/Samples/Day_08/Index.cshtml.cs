using Htmx;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Htmxmas.Pages.Samples.Day_08;

public class IndexModel : PageModel
{
    [BindProperty(SupportsGet = true)] 
    public int CurrentProgress { get; set; }
    public bool IsComplete => CurrentProgress >= 100;

    public IActionResult OnPostStart()
    {
        return Partial("_Start", this);
    }

    public IActionResult OnGetJob()
    {
        return Partial("_Job", this);
    }

    public IActionResult OnGetProgress()
    {
        CurrentProgress += Random.Shared.Next(5, 15);
        if (IsComplete)
        {
            // process is done, let the UI know
            Response.Htmx(h => h.WithTrigger("done"));
        }

        return Partial("_Start", this);
    }
}