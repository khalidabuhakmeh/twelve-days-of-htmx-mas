using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Htmxmas.Pages.Samples.Day_01;

public class IndexModel : PageModel
{
    /// <summary>
    /// This is a storage mechanism for the current count
    /// value, and it can be replaced by a database, service, etc.
    /// </summary>
    public static int Value { get; set; }

    public int Count => Value;

    public IActionResult OnPostIncrement()
    {
        Value++;
        return Partial("_Count", this);
    }

    public IActionResult OnPostReset()
    {
        Value = 0;
        return Partial("_Count", this);
    }
}