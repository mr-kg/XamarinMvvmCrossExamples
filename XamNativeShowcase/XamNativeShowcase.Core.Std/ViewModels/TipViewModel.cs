using MvvmCross;
using MvvmCross.Commands;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;
using XamNativeShowcase.Services;

namespace XamNativeShowcase.Core.ViewModels
{
    public class TipViewModel : MvxViewModel
    {
        readonly ICalculation _calculation;
        private IMvxNavigationService NavigationService => Mvx.IoCProvider.Resolve<IMvxNavigationService>();

        public TipViewModel(ICalculation calculation)
        {
            _calculation = calculation;
        }

        public override void Start()
        {
            _subTotal = 100;
            _generosity = 10;
            Recalculate();
            base.Start();
        }

        public IMvxCommand NavigateToMapViewCommand
        {
            get { return new MvxCommand(NavigateToMapView); }
        }

        public IMvxCommand NavigateToSignalRCommand
        {
            get { return new MvxCommand(NavigateToSignalR); }
        }

        private void NavigateToMapView()
        {
            NavigationService.Navigate<MapViewModel>();
        }

        private void NavigateToSignalR()
        {
            NavigationService.Navigate<SignalRViewModel>();
        }

        double _subTotal;

        public double SubTotal
        {
            get
            {
                return _subTotal;
            }
            set
            {
                _subTotal = value;
                RaisePropertyChanged(() => SubTotal);
                Recalculate();
            }
        }

        int _generosity;

        public int Generosity
        {
            get
            {
                return _generosity;
            }
            set
            {
                _generosity = value;
                RaisePropertyChanged(() => Generosity);
                Recalculate();
            }
        }

        double _tip;

        public double Tip
        {
            get
            {
                return _tip;
            }
            set
            {
                _tip = value;
                RaisePropertyChanged(() => Tip);
            }
        }

        void Recalculate()
        {
            Tip = _calculation.TipAmount(SubTotal, Generosity);
        }

        
    }
}
