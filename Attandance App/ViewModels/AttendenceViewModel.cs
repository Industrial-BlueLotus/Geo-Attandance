using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Maui.Devices.Sensors;
using Microsoft.VisualBasic;
using Newtonsoft.Json;
using RestSharp;
using RestSharp.Authenticators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Attandance_App.ViewModels
{
    public partial class AttendenceViewModel : ObservableObject
    {
        private CancellationTokenSource _cancelTokenSource;
        private bool _isCheckingLocation;


        [ObservableProperty]
        private DateTime _time1;

        [ObservableProperty]
        private DateTime _time2;

        [ObservableProperty]
        private TimeSpan _time3;

        [ObservableProperty]
        private Location _location;

        [ObservableProperty]
        private string _latitude1;

        [ObservableProperty]
        private string _longitude1;

        [ObservableProperty]
        private string _latitude2;

        [ObservableProperty]
        private string _longitude2;

        private Token tok;

        private DateToken _dateToken;

        private string apitoken = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6WyJWaWhhbi5CTCIsIlZpaGFuLkJMIl0sIm5hbWVpZCI6IlZpaGFuLkJMIiwiRmlyc3ROYW1lIjoiVmloYW4uQkwiLCJVc2VySWQiOiJWaWhhbi5CTCIsIkVtYWlsIjoiTm8gRW1haWwiLCJDQ0QiOiJEQyIsInJvbGUiOiJDb21wYW55QXV0aFN1Y2Nlc3MiLCJuYmYiOjE2NzMyNDU2NjEsImV4cCI6MTY3MzI4ODg2MSwiaWF0IjoxNjczMjQ1NjYxfQ.-y9CvxhdMEvvS5NWiatxUg6mMFxkRL8-KcFK2MQKn8M";

        [RelayCommand]
        public async void OnInButtonClick()
        {
            Time1 = DateTime.Now;
            Latitude1 = await GetLatiLocation();
            Longitude1 = await GetLongLocation();

            var client = new RestClient();

            tok = new Token();

            tok.CompanyId = 156;
            tok.UserKey = 342922;
            tok.EmpKy = 874258;
            tok.ShiftKy = 389916;
            tok.Latitude = 0.00;
            tok.Longitude = Longitude1;

            LocationParam lp = new LocationParam();

            lp.CodeKey = 397113;
            lp.CodeName = "";

            tok.Location = lp;

            tok.MultiAtnDetKy = 1;
            tok.IsHoliday = 0;
            tok.IsIn = 1;
            tok.IsOut = 0;
            tok.IsoutWithoutIn = 0;



            //client.Timeout = -1;
            var request = new RestRequest("https://bl360x.com/BLEComTest/api/HR/In").AddJsonBody(tok);
            request.Method = Method.Post;
            request.AddHeader("Accept", "application/json");

            request.AddHeader("IntegrationID", "1aa6a39b-5f54-4905-880a-a52733fd6105");
            request.AddHeader("Authorization", "Bearer "+apitoken);
            request.AddHeader("Content-Type", "application/json");


            RestResponse response = await client.PostAsync(request);



            // Check the status code of the response
            if (response.StatusCode == HttpStatusCode.OK)
            {
                // Read the response data
                var responseContent = response.Content.ToString();

                Console.WriteLine(responseContent);
            }
            else
            {
                Console.WriteLine("Request failed with status code: " + response.StatusCode);
            }
        }

        [RelayCommand]
        public async void OnOutButtonClick()
        {
            Time2 = DateTime.Now;
            Time3 = Time2.Subtract(Time1);
            Latitude2 = await GetLatiLocation();
            Longitude2 = await GetLongLocation();

            var client = new RestClient();

            tok = new Token();

            tok.CompanyId = 156;
            tok.UserKey = 342922;
            tok.EmpKy = 874258;
            tok.ShiftKy = 389916;
            tok.Latitude = 0.00;
            tok.Longitude = Longitude2;

            LocationParam lp = new LocationParam();

            lp.CodeKey = 397113;
            lp.CodeName = "";

            tok.Location = lp;

            tok.MultiAtnDetKy = 1;
            tok.IsHoliday = 0;
            tok.IsIn = 1;
            tok.IsOut = 1;
            tok.IsoutWithoutIn = 0;



            //client.Timeout = -1;
            var request = new RestRequest("https://bl360x.com/BLEComTest/api/HR/In").AddJsonBody(tok);
            request.Method = Method.Post;
            request.AddHeader("Accept", "application/json");

            request.AddHeader("IntegrationID", "1aa6a39b-5f54-4905-880a-a52733fd6105");
            request.AddHeader("Authorization", "Bearer "+apitoken);
            request.AddHeader("Content-Type", "application/json");

            RestResponse response = await client.PostAsync(request);



            // Check the status code of the response
            if (response.StatusCode == HttpStatusCode.OK)
            {
                // Read the response data
                var responseContent = response.Content.ToString();

                Console.WriteLine(responseContent);
            }
            else
            {
                Console.WriteLine("Request failed with status code: " + response.StatusCode);
            }

        }

        private void Datepicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            DatePickAync();
        }

        public async void DatePickAync()
        {
            var client = new RestClient();

            _dateToken = new DateToken();


            _dateToken.EmpKy = 874258;
            _dateToken.CompanyId = 156;
            _dateToken.FDT = new DateTime(2022 - 01 - 10);
            _dateToken.TDT = new DateTime(2022 - 01 - 31);
            _dateToken.Chk = 0;
            _dateToken.PrjKy = 1;
            _dateToken.TaskKy = 1;


            var request = new RestRequest("https://bl360x.com/BLEComTest/api/HR/MultiAtnAnlysis").AddJsonBody(_dateToken);
            request.Method = Method.Post;
            request.AddHeader("Accept", "application/json");

            request.AddHeader("IntegrationID", "1aa6a39b-5f54-4905-880a-a52733fd6105");
            request.AddHeader("Authorization", "Bearer "+apitoken);
            request.AddHeader("Content-Type", "application/json");

            RestResponse response = await client.PostAsync(request);



            // Check the status code of the response
            if (response.StatusCode == HttpStatusCode.OK)
            {
                // Read the response data
                var responseContent = response.Content.ToString();

                Console.WriteLine(responseContent);
            }
            else
            {
                Console.WriteLine("Request failed with status code: " + response.StatusCode);
            }
        }

        [RelayCommand]
        public async Task<string> GetLatiLocation()
        {
            try
            {
                _isCheckingLocation = true;

                GeolocationRequest request = new GeolocationRequest(GeolocationAccuracy.Medium, TimeSpan.FromSeconds(10));

                _cancelTokenSource = new CancellationTokenSource();

                Location = await Geolocation.Default.GetLocationAsync(request, _cancelTokenSource.Token);

                //location = await Geolocation.Default.GetLastKnownLocationAsync();


                if (Location != null)
                    return $"{Location.Latitude}";
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                // Handle not supported on device exception
            }


            return "None";
        }

        [RelayCommand]
        public async Task<string> GetLongLocation()
        {
            try
            {
                Location = await Geolocation.Default.GetLastKnownLocationAsync();

                if (Location != null)
                    return $"{Location.Longitude}";
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
