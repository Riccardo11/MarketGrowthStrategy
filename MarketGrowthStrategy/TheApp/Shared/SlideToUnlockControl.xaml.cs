namespace MarketGrowthStrategy.TheApp.Shared;

public partial class SlideToUnlockControl : ContentView
{
    public SlideToUnlockControl()
    {
        InitializeComponent();
    }

    private void PanGestureRecognizer_PanUpdated(object sender, PanUpdatedEventArgs e)
    {
        double realXTranslation;
#if ANDROID
        realXTranslation = Ellipse.TranslationX + e.TotalX;
#else
        realXTranslation = Ellipse.X + e.TotalX;
#endif
        double leftBoundary = Ellipse.X;
        double rightBoundary = SlideGrid.X + SlideGrid.Width - Ellipse.Width;
        
        if (realXTranslation >= leftBoundary
            && realXTranslation <= rightBoundary)
        {
            Ellipse.TranslationX = realXTranslation;
        }

        if (realXTranslation >= rightBoundary)
        {
            Shell.Current.GoToAsync("ProfilePage");
            Ellipse.TranslateTo(0, 0);
        }
    }
}