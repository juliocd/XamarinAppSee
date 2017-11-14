using Android.App;
using Android.Widget;
using Android.OS;
using AppseeAnalytics.Android;

namespace SeeExample.Android
{
    [Activity(Label = "SeeExample.Android", MainLauncher = true, Icon = "@mipmap/icon")]
    public class MainActivity : Activity
    {
        int count = 1;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            Appsee.SetUserId("7890t54");
            Appsee.SetLocationDescription("Office");
            Appsee.Start("f0a9498e4e7646d8b5937d1604dc5e37");

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            Button button = FindViewById<Button>(Resource.Id.myButton);

            button.Click += delegate { button.Text = $"{count++} clicks!"; };
        }
    }
}

