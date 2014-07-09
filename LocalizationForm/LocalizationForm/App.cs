using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LocalizationForm.AppResources;
using Xamarin.Forms;

namespace LocalizationForm
{
    public class App
    {
        public static Page GetMainPage()
        {
            return new ContentPage
            {
                Content = new Label
                {
                    Text = LocalizationResources.Sth,
                    BackgroundColor = Color.Red,
                    VerticalOptions = LayoutOptions.CenterAndExpand,
                    HorizontalOptions = LayoutOptions.CenterAndExpand,
                },
            };
        }
    }
}
