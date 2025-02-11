using ReTurnMySanity.ViewModels;

namespace ReTurnMySanity.Views;

public partial class ScanPage : ContentPage
{
	public ScanPage()
	{
		InitializeComponent();
		BindingContext = new ScanViewModel();

    }
}