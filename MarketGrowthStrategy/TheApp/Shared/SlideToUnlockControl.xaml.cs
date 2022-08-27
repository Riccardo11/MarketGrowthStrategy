namespace MarketGrowthStrategy.TheApp.Shared;

public partial class SlideToUnlockControl : ContentView
{
    public SlideToUnlockControl()
    {
        InitializeComponent();
    }

    private void PanGestureRecognizer_PanUpdated(object sender, PanUpdatedEventArgs e)
    {
        double realXTranslation = Ellipse.X + e.TotalX;
        double leftBoundary = Ellipse.X;
        double rightBoundary = SlideGrid.X + SlideGrid.Width - Ellipse.Width;

        const double OFFSET = 15;

        if (realXTranslation >= leftBoundary
            && realXTranslation <= rightBoundary)
        {
            Ellipse.TranslationX = realXTranslation;
        }

        if (realXTranslation >= rightBoundary - OFFSET)
        {
            Shell.Current.GoToAsync("ProfilePage");
            Ellipse.TranslateTo(0, 0);
        }
    }
}