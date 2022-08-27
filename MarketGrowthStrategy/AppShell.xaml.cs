using MarketGrowthStrategy.TheApp.Features.Home.Views;
using MarketGrowthStrategy.TheApp.Features.Overview.Views;
using MarketGrowthStrategy.TheApp.Features.Profile.View;

namespace MarketGrowthStrategy;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();

        Routing.RegisterRoute("ProfilePage", typeof(ProfilePage));
        Routing.RegisterRoute("OverviewPage", typeof(OverviewPage));
        
    }
}