using MarketGrowthStrategy.TheApp.Features.Profile.ViewModels;

namespace MarketGrowthStrategy.TheApp.Features.Profile.View;

public partial class ProfilePage : ContentPage
{
	public ProfilePage(ProfileViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}