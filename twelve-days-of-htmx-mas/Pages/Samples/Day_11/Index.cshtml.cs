using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Htmxmas.Pages.Samples.Day_11;

public class IndexModel : PageModel
{
    public ContentResult OnGetAllow()
    {
        var src = Url.Content("~/img/rudolph_happy.png");
        //language=html
        return Content($"""<img src="{src}" id="rudolph" alt="happy rudolph" class="img-fluid" />""");
    }

    public ContentResult OnGetDisallow()
    {
        var src = Url.Content("~/img/rudolph_sad.png");
        //language=html
        return Content($"""<img src="{src}" id="rudolph" alt="sad rudolph" class="img-fluid" />""");
    }
}