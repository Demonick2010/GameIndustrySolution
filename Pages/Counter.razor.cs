using Microsoft.AspNetCore.Components;
using static GameIndustry.Shared.MainLayout;

namespace GameIndustry.Pages
{
    // Урок 6
    public partial class Counter
    {
        //Урок 5
        [Inject] SingletonService singleton { get; set; }
        [Inject] TransientService trensient { get; set; }

        // Урок 7
        //[CascadingParameter(Name = "Color")] public string Color { get; set; }
        //[CascadingParameter(Name = "Size")] public string Size { get; set; }
        [CascadingParameter] public AppStyles Styles { get; set; }

        int counter = 0;

        void ClickHandler()
        {
            counter++;

            // Урок 5
            singleton.Value = counter;
            trensient.Value = counter;
        }
    }
}
