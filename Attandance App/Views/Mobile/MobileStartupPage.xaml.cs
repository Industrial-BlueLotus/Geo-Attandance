namespace Attandance_App.Views.Mobile;

public partial class MobileStartupPage : ContentPage
{
    public MobileStartupPage()
    {
        InitializeComponent();
    }

    private void OnBackClicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("//MainPage");
    }


}