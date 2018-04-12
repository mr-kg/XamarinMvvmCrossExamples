using MvvmCross.Binding.BindingContext;
using MvvmCross.iOS.Views;
using System;

using UIKit;
using XamNativeShowcase.ViewModels;

namespace XamNativeShowcase.iOS.Views
{
    public partial class TipView : MvxViewController<TipViewModel>
    {
        public TipView() : base("TipView", null)
        {
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();

            // Release any cached data, images, etc that aren't in use.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            // Perform any additional setup after loading the view, typically from a nib.
            this.CreateBinding(TipLabel).To((TipViewModel vm) => vm.Tip).Apply();
            this.CreateBinding(SubTotalTextField).To((TipViewModel vm) => vm.SubTotal).Apply();
            this.CreateBinding(GenerositySlider).To((TipViewModel vm) => vm.Generosity).Apply();

            // Resign first responder
            View.AddGestureRecognizer(new UITapGestureRecognizer(() => {
                this.SubTotalTextField.ResignFirstResponder();
            }));
        }
    }
}