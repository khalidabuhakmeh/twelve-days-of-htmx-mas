using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Htmxmas.Pages.Samples.Day_09;

public class IndexModel : PageModel
{
    public List<string> Colors { get; } =
    [
        "rgba(255, 0, 0, 1)", // Red
        "rgba(0, 255, 0, 1)", // Bright Green
        "rgba(255, 255, 0, 1)", // Yellow
        "rgba(255, 102, 0, 1)", // Bright Orange
        "rgba(255, 0, 255, 1)", // Magenta
        "rgba(0, 255, 255, 1)", // Cyan
        "rgba(0, 0, 255, 1)", // Blue
    ];

    public string PickRandomColor()
    {
        return Colors[Random.Shared.Next(Colors.Count)];
    }

    public PartialViewResult OnGetCell(string id)
    {
        return Partial("_Cell", new Cell(id, PickRandomColor()));
    }
}

public record Cell(string Id, string Color);