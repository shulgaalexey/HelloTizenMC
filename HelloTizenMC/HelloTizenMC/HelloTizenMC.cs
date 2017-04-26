using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

using Microsoft.Azure.Mobile;
using Microsoft.Azure.Mobile.Analytics;
using System.Collections.Generic;

namespace HelloTizenMC
{
    public class App : Application
    {
        public App()
        {
            // The root page of your application
            MainPage = new ContentPage
            {
                Content = new StackLayout
                {
                    VerticalOptions = LayoutOptions.Center,
                    Children = {
                        new Label {
                            HorizontalTextAlignment = TextAlignment.Center,
                            Text = "Welcome to Xamarin Forms!"
                        }
                    }
                }
            };
        }

        protected override void OnStart()
        {
            // Handle when your app starts

            try
            {
                MobileCenter.LogLevel = LogLevel.Verbose;
                MobileCenter.Start("2af1f802-b9a0-4382-b2f5-451d446604e5", typeof(Analytics));
                Analytics.TrackEvent("Video clicked", new Dictionary<string, string> { { "Category", "Music" }, { "FileName", "favorite.avi" } });

            }
            catch (Exception ex)
            {
                MobileCenterLog.Error(MobileCenterLog.LogTag, "Exception: " + ex.GetType());
                MobileCenterLog.Error(MobileCenterLog.LogTag, "Exception: " + ex.Message);
                MobileCenterLog.Error(MobileCenterLog.LogTag, "Exception: " + ex.StackTrace);
            }
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
