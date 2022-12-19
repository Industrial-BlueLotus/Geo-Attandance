
using Attandance_App.ViewModels;
using CommunityToolkit.Mvvm.ComponentModel;

namespace Attandance_App.Views.Desktop;


public partial class DesktopStartupPage : ContentPage
{
    //public DateTime time1 { get; set; }

    //public DateTime time2 { get; set; }



    public Location location { get; set; }



    public DesktopStartupPage()
    {
        InitializeComponent();

        AttendenceViewModel model = new AttendenceViewModel();
        this.BindingContext = model;



    }


    private void OnCounterClicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("//MainPage");
    }

    private void OnBackClicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("//MainPage");
    }




}