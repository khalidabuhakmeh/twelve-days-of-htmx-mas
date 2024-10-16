using Htmx;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Htmxmas.Pages.Samples.Day_06;

public class IndexModel : PageModel
{
    [BindProperty(SupportsGet = true)]
    public string SortBy { get; set; } = nameof(Person.Id);
    public IEnumerable<Person> People { get; set; } = Array.Empty<Person>();
    
    private static List<Person> Data { get; set; } =
        new()
        {
            new Person(1, "John", "Nice"),
            new Person(2, "Mary", "Nice"),
            new Person(3, "Alex", "Naughty"),
            new Person(4, "Sophia", "Naughty"),
            new Person(5, "James", "Nice")
        };

    public IActionResult OnGet()
    {
        People = SortBy switch
        {
            "Id" => Data.OrderBy(p => p.Id),
            "Name" => Data.OrderBy(p => p.Name),
            "Behavior" => Data.OrderBy(p => p.Behavior),
            _ => Data
        };

        return Request.IsHtmx()
            ? Partial("_Table", this)
            : Page();
    }
}

public record Person(int Id, string Name, string Behavior);