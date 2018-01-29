using Android.App;
using Android.OS;
using Android.Support.Design.Widget;
using Android.Support.V4.View;
using Android.Support.V7.App;

namespace AndroidNavigation
{
    [Activity(Label = "AndroidNavigation", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Main);

            TabLayout tabLayout = (TabLayout)FindViewById(Resource.Id.tablayout_navigation);

            ViewPager viewPager = (ViewPager)FindViewById(Resource.Id.pager);
            SetupViewPager(viewPager);

            tabLayout.SetupWithViewPager(viewPager);
        }

        private void SetupViewPager(ViewPager viewPager)
        {
            viewPager.OffscreenPageLimit = 3;

            PageAdapter adapter = new PageAdapter(SupportFragmentManager);
            adapter.AddFragment(new Fragment1(), "Read data");
            adapter.AddFragment(new Fragment2(), "Write data");
            adapter.AddFragment(new Fragment3(), "About the App");

            viewPager.Adapter = adapter;
        }

    }
}

