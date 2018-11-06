using MvvmCross.Platforms.Uap.Views;
using MvvmCross.ViewModels;
using XamNativeShowcase.Core.ViewModels;

namespace XamNativeShowcase.Uwp.Views
{
    [MvxViewFor(typeof(TipViewModel))]
    public sealed partial class TipView : MvxWindowsPage
    {
        public TipView()
        {
            this.InitializeComponent();
        }
    }
}
