

using CommunityToolkit.Mvvm.ComponentModel;

namespace Attandance_App.Views.Mobile;

public partial class MobileStartupPage : ObservableObject
{
    public DateTime Time1 { get; set; }
    public DateTime Time2 { get; set; }



    private void OnBackClicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("//MainPage");
    }

    private void OnInClicked(object sender, EventArgs e)
    {
        Time1 = DateTime.Now;
        Console.WriteLine(Time1);
    }

    private void OnOutClicked(object sender, EventArgs e)
    {
        Time2 = DateTime.Now;
        Console.WriteLine(Time2);
    }



}