using Android.App;
using MvvmCross.Platforms.Android.Views;

namespace XamNativeShowcase.Droid.Views
{
    [Activity(Label = "Map")]
    public class MapView : MvxActivity
    {
        protected override void OnViewModelSet()
        {
            SetContentView(Resource.Layout.View_Map);
        }
    }
}