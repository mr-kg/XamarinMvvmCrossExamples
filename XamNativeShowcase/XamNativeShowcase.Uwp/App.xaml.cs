using MvvmCross.Platforms.Uap.Core;
using MvvmCross.Platforms.Uap.Views;

namespace XamNativeShowcase.Uwp
{
    public sealed partial class App
    {
        public App()
        {
            InitializeComponent();
        }
    }

    public abstract class TipCalcApp : MvxApplication<MvxWindowsSetup<XamNativeShowcase.App>, XamNativeShowcase.App>
    {
    }
}
