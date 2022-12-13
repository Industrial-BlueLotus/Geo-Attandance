namespace Attandance_App.Views.Desktop;

public partial class DesktopStartupPage : ContentPage
{
    public DateTime time1 { get; set; }
    public DateTime time2 { get; set; }

    public Location location { get; set; }

    public DesktopStartupPage()
    {
        InitializeComponent();
        time1 = DateTime.Now;
        time2 = DateTime.Now;

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
        GetCachedLocation();
    }

    private void OnOutClicked(object sender, EventArgs e)
    {
        time2 = DateTime.Now;
        Console.WriteLine(time2);
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

}