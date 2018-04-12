using MvvmCross.Core.ViewModels;
using MvvmCross.Platform.Logging;
using MvvmCross.Uwp.Platform;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace XamNativeShowcase.Uwp
{
    public class Setup : MvxWindowsSetup
    {
        public Setup(Frame rootFrame) : base(rootFrame)
        {
        }

        protected override IMvxApplication CreateApp()
        {
            return new XamNativeShowcase.App();
        }

        /// <summary>
        /// On UWP, it expects a log provider for some reason - here we just return None
        /// </summary>
        /// <returns></returns>
        protected override MvxLogProviderType GetDefaultLogProviderType()
            => MvxLogProviderType.None;
    }
}
