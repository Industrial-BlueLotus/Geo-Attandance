using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Attandance_App.Views.Desktop;

public partial class DesktopStartupPage : ContentPage, INotifyPropertyChanged
{
    //public DateTime time1 { get; set; }

    DateTime _time1;
    DateTime _time2;
    //public DateTime time2 { get; set; }



    public Location location { get; set; }

    public DateTime Time1
    {
        get => _time1;
        set => SetProperty(ref _time1, value);
    }

    public DateTime Time2
    {
        get => _time2;
        set => SetProperty(ref _time2, value);
    }

    public DesktopStartupPage()
    {
        InitializeComponent();
        Time1 = DateTime.Now;
        Time2 = DateTime.Now;
        this.BindingContext = this;



    }

    private void OnBackClicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("//MainPage");
    }

  
    public async Task<string> GetCachedLocation()
    {
        try
        {
            //Location location = await Geolocation.Default.GetLastKnownLocationAsync();

            if (location != null)
                return $"Latitude: {location.Latitude}, Longitude: {location.Longitude}, Altitude: {location.Altitude}";
        }
        catch (FeatureNotSupportedException fnsEx)
        {
            // Handle not supported on device exception
        }
        catch (FeatureNotEnabledException fneEx)
        {
            // Handle not enabled on device exception
        }
        catch (PermissionException pEx)
        {
            // Handle permission exception
        }
        catch (Exception ex)
        {
            // Unable to get location
        }

        return "None";
    }

    private void DatePicker_DateSelected(object sender, DateChangedEventArgs e)
    {
        Time1 = mDatePicker.Date;
        Time2 = mDatePicker.Date;
    }
    private void OnInClicked(object sender, EventArgs e)
    {
        Console.WriteLine(Time1);

    }

    private void OnOutClicked(object sender, EventArgs e)
    {

        Console.WriteLine(Time1);

    }
    bool SetProperty<T>(ref T storage, T value, [CallerMemberName] string propertyName = null)
    {
        if (Object.Equals(storage, value))
            return false;

        storage = value;
        OnPropertyChanged(propertyName);
        return true;
    }

    protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    public event PropertyChangedEventHandler PropertyChanged;
}