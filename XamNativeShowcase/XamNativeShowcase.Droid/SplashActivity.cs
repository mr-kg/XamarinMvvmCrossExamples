using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Esri.ArcGISRuntime.Mapping;
using MvvmCross.Droid.Views;

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