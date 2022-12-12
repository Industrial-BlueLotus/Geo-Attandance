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

    //protected override void OnAppearing()
    //{
    //    base.OnAppearing();
    //    outerGrid.Loaded += OuterGrid_Loaded;
    //    this.SizeChanged += MainPage_SizeChanged;
    //}

    //private void MainPage_SizeChanged(object sender, EventArgs e)
    //{
    //    horizontalGrid.WidthRequest = outerGrid.Width;
    //    verticalGrid.WidthRequest = outerGrid.Width;
    //}

    //private void OuterGrid_Loaded(object sender, EventArgs e)
    //{
    //    horizontalGrid.WidthRequest = outerGrid.Width;
    //    verticalGrid.WidthRequest = outerGrid.Width;
    //}


}