
using Client.Rest;
using Microsoft.Maui.Devices.Sensors;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Client.Test
{
    public class RestService : IRestService
    {
        HttpClient _client;
        JsonSerializerOptions _serializerOptions;

        public List<TodoItem> Items { get; private set; }

        public RestService()
        {
            _client = new HttpClient();
            _serializerOptions = new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                WriteIndented = true
            };
        }

    }

    public interface IRestService
    {
    }
}
