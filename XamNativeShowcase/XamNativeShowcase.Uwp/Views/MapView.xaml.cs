using MvvmCross.Platforms.Uap.Views;
using MvvmCross.ViewModels;
using XamNativeShowcase.Core.ViewModels;

namespace XamNativeShowcase.Uwp.Views
{
    [MvxViewFor(typeof(MapViewModel))]
    public sealed partial class MapView : MvxWindowsPage
    {
        public MapView()
        {
            this.InitializeComponent();
        }
    }
}
