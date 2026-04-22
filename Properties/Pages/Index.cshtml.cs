using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

public class IndexModel : PageModel
{
    [BindProperty] public double OuterLength { get; set; }
    [BindProperty] public double OuterWidth { get; set; }
    [BindProperty] public double OuterHeight { get; set; }

    [BindProperty] public double InnerLength { get; set; }
    [BindProperty] public double InnerWidth { get; set; }
    [BindProperty] public double InnerHeight { get; set; }

    [BindProperty] public double DomeFactor { get; set; }
    [BindProperty] public double TwistFactor { get; set; }

    public double Result { get; set; }

    public void OnPost()
    {
        double outerVolume = OuterLength * OuterWidth * OuterHeight;
        double innerVolume = InnerLength * InnerWidth * InnerHeight;

        double hollowVolume = outerVolume - innerVolume;

        Result = hollowVolume * DomeFactor * TwistFactor;
    }
}