using Microsoft.AspNetCore.Components;

namespace GameIndustry.Pages
{
    // Урок 6
    public partial class Counter
    {
        //Урок 5
        [Inject] SingletonService singleton { get; set; }
        [Inject] TransientService trensient { get; set; }

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
