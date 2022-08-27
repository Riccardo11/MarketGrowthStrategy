using System.Runtime.CompilerServices;

namespace MarketGrowthStrategy.TheApp.Shared;

public partial class IndicatorView : ContentView
{
	public IndicatorView()
	{
		InitializeComponent();
	}

	public double Percentage { get; set; }

	protected override void OnPropertyChanged([CallerMemberName] string propertyName = null)
	{
		base.OnPropertyChanged(propertyName);

		if (propertyName == "Height"
			&& Height > 0)
		{
            LevelView.HeightRequest = Height * Percentage / 100;
        }
	}
}