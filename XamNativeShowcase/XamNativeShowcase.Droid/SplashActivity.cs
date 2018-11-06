using Android.App;
using Android.OS;
using Esri.ArcGISRuntime.Mapping;
using MvvmCross.Platforms.Android.Views;

namespace XamNativeShowcase.Droid
{
    [Activity(Label = "SplashActivity")]
    public class SplashActivity : MvxSplashScreenActivity
    {
        public SplashActivity() : base(Resource.Layout.Splash)
        {
            Map m = new Map();
        }

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
        }
    }
}