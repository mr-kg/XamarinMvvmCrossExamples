using MvvmCross.Platforms.Android.Core;
using MvvmCross.ViewModels;

namespace XamNativeShowcase.Droid
{
    public class Setup : MvxAndroidSetup<App>
    {
        public Setup()
        {
        }

        protected override IMvxApplication CreateApp()
        {
            return new App();
        }
    }
}