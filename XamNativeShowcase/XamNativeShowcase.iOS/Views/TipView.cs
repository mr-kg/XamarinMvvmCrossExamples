using MvvmCross.Binding.BindingContext;
using MvvmCross.Platforms.Ios.Views;
using System;
using XamNativeShowcase.Core.ViewModels;

namespace XamNativeShowcase.iOS
{
    [MvxFromStoryboard("TipView")]
    public partial class TipView : MvxViewController<TipViewModel>
    {
        public TipView(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            var set = this.CreateBindingSet<TipView, TipViewModel>();
            set.Bind(TipLabel).To(vm => vm.Tip);
            set.Bind(SubTotalTextField).To(vm => vm.SubTotal);
            set.Bind(GenerositySlider).To(vm => vm.Generosity);
            set.Apply();
        }

    }
}