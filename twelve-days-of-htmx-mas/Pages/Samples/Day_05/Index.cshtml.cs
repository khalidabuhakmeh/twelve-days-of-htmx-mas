using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Htmxmas.Pages.Samples.Day_05;

public class Index : PageModel
{
    public async Task<PartialViewResult> OnGetHouses()
    {
        await Task.Delay(500);
        return Partial("_Houses");
    }
}