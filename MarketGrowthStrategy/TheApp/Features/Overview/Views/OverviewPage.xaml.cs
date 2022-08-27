namespace MarketGrowthStrategy.TheApp.Features.Overview.Views;

public partial class OverviewPage : ContentPage
{
	public OverviewPage()
	{
		InitializeComponent();
	}

	private async void OnBackTapped(object sender, EventArgs e)
	{
		await Shell.Current.GoToAsync("..");
	}
}