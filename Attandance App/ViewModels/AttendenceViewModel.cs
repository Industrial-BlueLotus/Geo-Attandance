﻿using CommunityToolkit.Mvvm.ComponentModel;
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
        private string longitude1;

        [ObservableProperty]
        private string latitude2;

        [ObservableProperty]
        private string longitude2;
        private Token tok;

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
            tok.Longitude = 0.00;

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
            var request = new RestRequest("http://localhost:62185/api/HR/In").AddJsonBody(tok);
            request.Method = Method.Post;
            request.AddHeader("Accept", "application/json");

            request.AddHeader("IntegrationID", "1aa6a39b-5f54-4905-880a-a52733fd6105");
            request.AddHeader("Authorization", "Bearer eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6IlZpaGFuLkJMIiwibmFtZWlkIjoiVmloYW4uQkwiLCJyb2xlIjoiVXNlciIsIkZpcnN0TmFtZSI6IlZpaGFuLkJMIiwiTGFzdE5hbWUiOiJWaWhhbi5CTCIsIlVzZXJJZCI6IlZpaGFuLkJMIiwiRW1haWwiOiJObyBFbWFpbCIsIkNDRCI6Ii0tTk9OQ0UtLSIsIm5iZiI6MTY3MjMwNTgwOCwiZXhwIjoxNjcyMzQ5MDA4LCJpYXQiOjE2NzIzMDU4MDh9.Wqs9EJbcjSeidfACfbeKpOXSTBnq2xYvf0T5JSMZi_w");
            request.AddHeader("Content-Type", "application/json");

            //request.AddJsonBody
            //request.AddParameter("CompanyId", "156", ParameterType.GetOrPost);
            //request.AddParameter("UserKey", "342922", ParameterType.GetOrPost);
            //request.AddParameter("EmpKy", "874258", ParameterType.GetOrPost);
            //request.AddParameter("ShiftKy", "389916", ParameterType.GetOrPost);
            //request.AddParameter("Latitude", "0.00", ParameterType.GetOrPost);
            //request.AddParameter("Longitude", "0.00", ParameterType.GetOrPost);
            //request.AddParameter("Location.Codekey", "397113", ParameterType.GetOrPost);
            //request.AddParameter("MultiAtnDetKy", "1", ParameterType.GetOrPost);
            //request.AddParameter("IsHoliday", "0", ParameterType.GetOrPost);
            //request.AddParameter("IsIn", "1", ParameterType.GetOrPost);
            //request.AddParameter("IsOut", "0", ParameterType.GetOrPost);
            //request.AddParameter("IsoutWithoutIn", "0", ParameterType.GetOrPost);

            //var response = await client.PostAsync(request);
            //var content = response.Content.ToString();

            //var result = JsonConvert.DeserializeObject<TokenResponse>(content);
            //var request = new RestRequest(Method.POST);

            //request.AddParameter("application/json", body, ParameterType.RequestBody);

            //RestResponse response = client.Execute(request);
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

        }

        [RelayCommand]
        public async Task<string> GetLatiLocation()
        {
            try
            {
                _isCheckingLocation = true;

                GeolocationRequest request = new GeolocationRequest(GeolocationAccuracy.Medium, TimeSpan.FromSeconds(10));

                _cancelTokenSource = new CancellationTokenSource();

                location = await Geolocation.Default.GetLocationAsync(request, _cancelTokenSource.Token);

                //location = await Geolocation.Default.GetLastKnownLocationAsync();


                if (location != null)
                    return $"{location.Latitude}";
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
                location = await Geolocation.Default.GetLastKnownLocationAsync();

                if (location != null)
                    return $"{location.Longitude}";
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
