using MvvmCross.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XamNativeShowcase.Services;

namespace XamNativeShowcase.ViewModels
{
    public class TipViewModel : MvxViewModel
    {
        readonly ICalculation _calculation;

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
