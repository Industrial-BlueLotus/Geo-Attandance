namespace Attandance_App.Views.Desktop;

public partial class DesktopStartupPage : ContentPage
{
    public DesktopStartupPage()
    {
        InitializeComponent();
    }

    private void OnBackClicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("//MainPage");
    }
}