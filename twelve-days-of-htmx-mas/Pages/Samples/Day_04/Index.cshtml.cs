using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Htmxmas.Pages.Samples.Day_04;

public class Index : PageModel
{
    public ContentResult OnGetDrop()
    {
        // language=html
        return Content(
            """
            <div class="alert alert-info">
                 <h5>🎁 Gift Received</h5>
                 <p>Thanks! I'm sure they'll love it! ❤️</p>
                 <button class="btn btn-danger" onclick="location.reload()">♺ Reload</button>
            </div>
            """
        );
    }
}