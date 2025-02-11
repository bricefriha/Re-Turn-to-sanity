using ReTurnMySanity.ViewModels;

namespace ReTurnMySanity.Views;

public partial class CouponsPage : ContentPage
{
	public CouponsPage()
	{
		InitializeComponent();
		BindingContext = new CouponsViewModel();
	}
}