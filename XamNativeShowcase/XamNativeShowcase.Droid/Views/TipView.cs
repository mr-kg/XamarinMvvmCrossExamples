﻿using Android.App;
using MvvmCross.Platforms.Android.Views;

namespace XamNativeShowcase.Droid.Views
{
    [Activity(Label = "Tip", MainLauncher = true)]
    public class TipView : MvxActivity
    {
        protected override void OnViewModelSet()
        {
            SetContentView(Resource.Layout.View_Tip);
        }
    }
}