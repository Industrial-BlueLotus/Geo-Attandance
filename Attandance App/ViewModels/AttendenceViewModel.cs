using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Maui.Devices.Sensors;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attandance_App.ViewModels
{
    public partial class AttendenceViewModel : ObservableObject
    {


        [ObservableProperty]
        private DateTime time1;

        [ObservableProperty]
        private DateTime time2;

        [ObservableProperty]
        private TimeSpan time3;

        [ObservableProperty]
        private Location location;

        [ObservableProperty]
        private string latitude1;

        [ObservableProperty]
        private double longtitude1;

        [RelayCommand]
        public void OnInButtonClick()
        {
            Time1 = DateTime.Now;
            GetCachedLocation();
        }

        [RelayCommand]
        public void OnOutButtonClick()
        {
            Time2 = DateTime.Now;
            Time3 = Time2.Subtract(Time1);

        }

        [RelayCommand]
        public async Task<string> GetCachedLocation()
        {
            try
            {
                location = await Geolocation.Default.GetLastKnownLocationAsync();

                if (location != null)
                    return Latitude1 = location.Latitude;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                // Handle not supported on device exception
            }


            return "None";
        }


    }
}
