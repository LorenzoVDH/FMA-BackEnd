using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetManager.MAUIFront.HelperClasses;
public static class ViewHelperClass
{
    public static PageColours GetPageColours(string color1Key, string color2Key, string color3Key)
    {
        PageColours colours = new PageColours();

        if (Application.Current.Resources.TryGetValue(color1Key, out var colour))
        {
            colours.PrimaryColour = (Color)colour;
        }
        if (Application.Current.Resources.TryGetValue(color2Key, out var colour2))
        {
            colours.SecondaryColour = (Color)colour2;
        }
        if (Application.Current.Resources.TryGetValue(color3Key, out var colour3))
        {
            colours.TertiaryColour = (Color)colour3;
        }

        return colours;
    }

    public static void SetPageColours(Color bgColour, Color textColour)
    {
        var navigationPage = Application.Current.MainPage as NavigationPage;
        navigationPage.BarBackgroundColor = bgColour;
        navigationPage.BarTextColor = textColour;
    }
}
