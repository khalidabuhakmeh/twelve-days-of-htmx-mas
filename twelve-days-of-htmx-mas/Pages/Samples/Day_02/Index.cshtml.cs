using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Htmxmas.Pages.Samples.Day_02;

public class IndexModel : PageModel
{
    public static List<SelectListItem> BehaviorOptions =
    [
        new ("Select your behavior...", ""),
        new("Naughty", "Naughty"),
        new("Nice", "Nice")
    ];
    
    [BindProperty,
     Required(AllowEmptyStrings = false)] 
    public string Name { get; set; } = "";

    [BindProperty,
     Required(AllowEmptyStrings = false)]
    public string Present { get; set; } = "";

    [BindProperty,
     Required(AllowEmptyStrings = false),
     AllowedValues("Naughty", "Nice")]
    public string Behavior { get; set; } = "";

    public IActionResult OnPost()
    {
        if (!ModelState.IsValid)
        {
            // 422 = "I understood you, but the data is invalid". htmx 4 swaps 4xx responses by default.
            Response.StatusCode = StatusCodes.Status422UnprocessableEntity;
            return Partial("_Form", this);
        }

        return Partial("_Alert", this);
    }
}