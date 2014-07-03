ResxForms
=========

Resx Localization in Xamarin Forms

https://github.com/xhackers/ResxForms/tree/LocalizationForm

Detail:

Create AppResouces Folder in PCL/Shared Project
Create LocalizationResources.resx & LocalizationResources.vi-VN.resx.
Change both files' Access Modifier to Public
Copy ResourceFlowDirection and ResourceLanguage From Windows Phone > Resources > resx into the Shared resx. (Resource Language in LocalizationResources.vi-VN.resx should be vi-VN)
Create LocalizedStrings.cs and add the following code:
namespace LocalizationForm.AppResources {     public class LocalizedStrings     {         private static readonly LocalizationResources _localizedResources = new LocalizationResources();         public LocalizationResources LocalizationResources { get { return _localizedResources; } }     } }
Delete Resource folder & LocalizedStrings.cs in Windows Phone Project
Re-reference your Resources in App.xaml and App.xaml.cs to the files (Resx &LocalizedStrings.cs) in Shared Project.
Run & Enjoy
You need the above to set up Localization for you Project: to show a string, for example MainPage_TitleLabel, add that string to both Resx file (English and Vietnamese). And simply use it like:

public static Page GetMainPage()
        {
            return new ContentPage
            {
                Content = new Label
                {
                    Text = LocalizationResources.MainPage_TitleLabel,
                    VerticalOptions = LayoutOptions.CenterAndExpand,
                    HorizontalOptions = LayoutOptions.CenterAndExpand,
                },
            };
        }

