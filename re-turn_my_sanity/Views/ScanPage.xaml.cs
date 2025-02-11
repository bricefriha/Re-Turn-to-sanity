using ReTurnMySanity.ViewModels;
using ZXing.Net.Maui;

namespace ReTurnMySanity.Views;

public partial class ScanPage : ContentPage
{
    private ScanViewModel _vm;

    public ScanPage()
	{
		InitializeComponent();
		BindingContext = _vm = new ScanViewModel();
        cameraBarcodeReaderView.Options = new BarcodeReaderOptions
        {
            Formats = BarcodeFormats.OneDimensional,
            AutoRotate = true,
            Multiple = true
        };

    }

    private void cameraBarcodeReaderView_BarcodesDetected(object sender, ZXing.Net.Maui.BarcodeDetectionEventArgs e)
    {
        _vm.Scanned = true;
    }
}