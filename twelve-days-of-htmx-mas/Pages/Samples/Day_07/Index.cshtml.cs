using Htmx;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Htmxmas.Pages.Samples.Day_07;

public class IndexModel : PageModel
{
    [BindProperty(SupportsGet = true)] public string Search { get; set; } = string.Empty;

    public IEnumerable<string> Results { get; set; } = Array.Empty<string>();
    public int TotalCount { get; } = Data.Length;

    public static string[] Data { get; } =
    [
        "Smartphone",
        "Wireless Headphones",
        "Bluetooth Speaker",
        "Smart Watch",
        "Laptop",
        "Digital Camera",
        "Tablet",
        "Coffee Maker",
        "Electric Kettle",
        "Fitness Tracker",
        "Kindle E-reader",
        "Portable Charger",
        "Drone",
        "Board Games",
        "Gift Cards",
        "Personalized Mug",
        "Cozy Blanket",
        "Winter Jacket",
        "Puzzle Set",
        "Scented Candles"
    ];

    public IActionResult OnGet()
    {
        Results = Search switch
        {
            { Length: > 0 } => Data.Where(x => x.Contains(Search, StringComparison.OrdinalIgnoreCase)),
            _ => Data
        };
        
        return Request.IsHtmx()
            ? Partial("_Results", this)
            : Page();
    }
}