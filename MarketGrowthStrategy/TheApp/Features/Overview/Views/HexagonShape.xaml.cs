using Microsoft.Maui.Controls.Shapes;

namespace MarketGrowthStrategy.TheApp.Features.Overview.Views;

public partial class HexagonShape : ContentView
{
	public HexagonShape()
	{
		InitializeComponent();
#if ANDROID
		IsVisible = false;
#endif
	}

	public double HexagonOpacity
	{
		get => Hexagon.Opacity;
		set => Hexagon.Opacity = value;
	}
}