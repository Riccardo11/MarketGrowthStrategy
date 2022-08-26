using MarketGrowthStrategy.TheApp.Features.Profile.View;
using MarketGrowthStrategy.TheApp.Features.Profile.ViewModels;

namespace MarketGrowthStrategy;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                fonts.AddFont("Roboto-Black.ttf", "RobotoBlack");
                fonts.AddFont("Roboto-Black.ttf", "RobotoBlack");
                fonts.AddFont("Roboto-Bold.ttf", "RobotoBold");
                fonts.AddFont("Roboto-Thin.ttf", "RobotoThin");
                fonts.AddFont("Roboto-Regular.ttf", "Roboto");
            });

        builder.Services.AddTransient<ProfileViewModel>();

        builder.Services.AddTransient<ProfilePage>();

        return builder.Build();
    }
}