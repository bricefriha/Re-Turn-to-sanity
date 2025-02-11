using ReTurnMySanity.ViewModels;

namespace ReTurnMySanity.Views;

public partial class CouponsPage : ContentPage
{
	public CouponsPage()
	{
		InitializeComponent();
		BindingContext = new CouponsViewModel();
	}

    private async void AddButton_Clicked(object sender, EventArgs e)
    {
		await Navigation.PushAsync(new ScanPage());
    }
}