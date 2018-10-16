using Windows.UI.Xaml.Controls;
using MvvmCross.Core.ViewModels;
//using MvvmCross.WindowsUWP.Platform;
using MvvmCross.Uwp.Views;
using System.Threading.Tasks;
using System;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace XamNativeShowcase.Uwp.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class TipView : MvxWindowsPage
    {
        public TipView()
        {
            this.InitializeComponent();

            this.Loaded += TipView_Loaded;
        }

        private void TipView_Loaded(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            //Init();
        }

        public async Task Init()
        {
            var picker = new Windows.Storage.Pickers.FileOpenPicker();
            picker.ViewMode = Windows.Storage.Pickers.PickerViewMode.Thumbnail;
            picker.SuggestedStartLocation = Windows.Storage.Pickers.PickerLocationId.PicturesLibrary;
            picker.FileTypeFilter.Add(".jpg");
            picker.FileTypeFilter.Add(".jpeg");
            picker.FileTypeFilter.Add(".png");

            Windows.Storage.StorageFile file = await picker.PickSingleFileAsync();
            if (file != null)
            {
                // Application now has read/write access to the picked file
                //this.textBlock.Text = "Picked photo: " + file.Name;
            }
            else
            {
                //this.textBlock.Text = "Operation cancelled.";
            }
        }

        private async void Button_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            await Init();
        }
    }
}
