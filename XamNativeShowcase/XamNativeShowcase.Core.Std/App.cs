using MvvmCross;
using MvvmCross.ViewModels;
using XamNativeShowcase.Core.ViewModels;
using XamNativeShowcase.Services;
namespace XamNativeShowcase
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            Mvx.IoCProvider.RegisterType<ICalculation, Calculation>();

            RegisterAppStart<TipViewModel>();
        }
    }
}
