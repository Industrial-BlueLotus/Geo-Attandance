

using CommunityToolkit.Mvvm.ComponentModel;

namespace Attandance_App.Views.Desktop;



public partial class DesktopStartupPage : ObservableObject
{
    public DateTime Time1 { get; set; }
    public DateTime Time2 { get; set; }



    public Location location { get; set; }





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

    //private void DatePicker_DateSelected(object sender, DateChangedEventArgs e)
    //{
    //    Time1 = mDatePicker.Date;
    //    Time2 = mDatePicker.Date;
    //}
    private void OnInClicked(object sender, EventArgs e)
    {
        Console.WriteLine(Time1);

    }

    private void OnOutClicked(object sender, EventArgs e)
    {

        Console.WriteLine(Time1);

    }

}