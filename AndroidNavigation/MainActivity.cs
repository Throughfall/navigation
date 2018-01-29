using Android.App;
using Android.Widget;
using Android.OS;

namespace AndroidNavigation
{
    [Activity(Label = "AndroidNavigation", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
        }
    }
}

