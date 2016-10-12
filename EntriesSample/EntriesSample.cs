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
                            Placeholder = "Entry with border",
                            HasBorder = true,
                            CursorColor = Color.Green,
                            HorizontalTextAlignment = TextAlignment.Center,
                        },
                        new ExtendedEntry {
                            Margin = 10,
                            Placeholder = "Entry without border",
                            HasBorder = false,
                            CursorColor = Color.Green,
                            HorizontalTextAlignment = TextAlignment.Center,
                        },
                        new ExtendedEntry {
                            Margin = 10,
                            Placeholder = "Plain cell style",
                            StyleClass = new string [] {"PlainCell"},
                            CursorColor = Color.Green,
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
