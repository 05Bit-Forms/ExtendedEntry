using System;
using Xamarin.Forms;
using Uniforms.ExtendedEntry;

namespace EntriesSample
{
    public class App : Application
    {
        public App ()
        {
            // The root page of your application
            var content = new ContentPage {
                Title = "EntriesSample",
                Content = new StackLayout {
                    VerticalOptions = LayoutOptions.Start,
                    Children = {
                        new ExtendedEntry {
                            Margin = 10,
                            Placeholder = "Entry without border",
                            HasBorder = false,
                            CursorColor = Color.Purple,
                            HorizontalTextAlignment = TextAlignment.Center,
                        },
                    }
                }
            };

            MainPage = new NavigationPage (content);
        }

        protected override void OnStart ()
        {
            // Handle when your app starts
        }

        protected override void OnSleep ()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume ()
        {
            // Handle when your app resumes
        }
    }
}
