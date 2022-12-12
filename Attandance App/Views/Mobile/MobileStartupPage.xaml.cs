namespace Attandance_App.Views.Mobile;

public partial class MobileStartupPage : ContentPage
{
    public DateTime time1 { get; set; }
    public MobileStartupPage()
    {
        InitializeComponent();
        time1= DateTime.Now;
        BindingContext = this;
    }

    private void OnBackClicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("//MainPage");
    }

    private void OnInClicked(object sender, EventArgs e)
    {
        time1 = DateTime.Now;
        Console.WriteLine(time1);
    }

    private void OnOutClicked(object sender, EventArgs e)
    {
        DateTime time2 = DateTime.Now;
        Console.WriteLine(time2);
    }



}