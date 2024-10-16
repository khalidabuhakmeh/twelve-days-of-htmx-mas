using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Htmxmas.Pages.Samples.Day_12;

public class IndexModel : PageModel
{
    [BindProperty] public string Card { get; set; } = "question";

    public Dictionary<string, string> Choices = new(StringComparer.OrdinalIgnoreCase)
    {
        { "question", "~/img/cards/question.png" },
        { "jacket", "~/img/cards/jacket.png" },
        { "mittens", "~/img/cards/mittens.png" },
        { "socks", "~/img/cards/socks.png" },
        { "hat", "~/img/cards/hat.png" }
    };


    public ContentResult OnPostCard()
    {
        if (!Choices.TryGetValue(Card, out var src))
        {
            src = Choices["question"];
        }

        // language=html
        return Content($"""
                        <img
                            id="card" 
                            src="{Url.Content(src)}"
                            alt="{Path.GetFileNameWithoutExtension(src)}"
                            class="img-fluid" />
                        """);
    }
}