using System;
using Microsoft.Azure.Mobile;
using Microsoft.Azure.Mobile.Analytics;
using Microsoft.Azure.Mobile.Crashes;
using System.Collections.Generic;

namespace HelloTizenMC.TizenMobile
{
    class Program : global::Xamarin.Forms.Platform.Tizen.FormsApplication
    {
        protected override void OnCreate()
        {
            base.OnCreate();
            LoadApplication(new App());

            MobileCenter.Start("2af1f802-b9a0-4382-b2f5-451d446604e5",
                   typeof(Analytics)
                   //, typeof(Crashes)
                   );

            Analytics.TrackEvent("Video clicked", new Dictionary<string, string> { { "Category", "Music" }, { "FileName", "favorite.avi" } });
        }

        static void Main(string[] args)
        {
            var app = new Program();
            global::Xamarin.Forms.Platform.Tizen.Forms.Init(app);
            app.Run(args);
        }
    }
}
