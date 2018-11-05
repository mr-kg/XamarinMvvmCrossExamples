using MvvmCross.Platforms.Uap.Views;
using MvvmCross.ViewModels;
using XamNativeShowcase.Core.ViewModels;

namespace XamNativeShowcase.Uwp.Views
{
    [MvxViewFor(typeof(SignalRViewModel))]
    public sealed partial class SignalRView : MvxWindowsPage
    {
        public SignalRView()
        {
            this.InitializeComponent();
        }
    }
}
