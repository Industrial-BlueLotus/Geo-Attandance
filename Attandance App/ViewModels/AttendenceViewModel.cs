using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
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
        private DateTime loggedInTime;

        [ObservableProperty]
        private DateTime time1;

        [ObservableProperty]
        private DateTime time2;


        [ObservableProperty]
        private DateTime latitude;

        [RelayCommand]
        public void OnInButtonClick()
        {
            int c = 0;
        }


    }
}
