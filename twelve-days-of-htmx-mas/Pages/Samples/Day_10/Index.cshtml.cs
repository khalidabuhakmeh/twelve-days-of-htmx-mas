using Htmx;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Htmxmas.Pages.Samples.Day_10;

public class IndexModel : PageModel
{
    public void OnGet()
    {
    }

    public PartialViewResult OnGetUncoloredSweater()
    {
        return Partial("_Image");
    }

    public ContentResult OnGetColoredSweater()
    {
        // language=html
        return Content(
            $"""
             <img 
                  id="sweater"
                  alt="colored sweater"
                  hx-swap-oob="true"
                  class="img-fluid"
                  src="{Url.Content("~/img/sweater_color.png")}" >
             """
        );
    }

    public NoContentResult OnGetReset()
    {
        Response.Htmx(h => h.WithTrigger("reset"));
        // don't return stuff
        return new NoContentResult();
    }
}