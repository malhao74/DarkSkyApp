using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;
using System.Configuration;
using Models;

namespace DataLayer
    {/// <summary>
    /// Class to fetch weather information from Dark sky API
    /// </summary>
    internal class DataLayerDarkSky : IDataLayerInterface<DarkSky>
    {
        #region Fields & properties
        private readonly string link = "https://api.darksky.net/forecast";

        private double _latitude;
        private double _longitude;

        public double Latitude { get { return _latitude; }  }
        public double Longitude { get { return _longitude; } }

        public event EventHandler<DataLayerEventArgs<DarkSky>> GotDataEventHandler;

        #endregion

        public DataLayerDarkSky() { }

        public void SetLocation(double latitude, double longitude)
        {
            _latitude = latitude;
            _longitude = longitude;
        }

        public async void GetDataAsync()
        {
            // Fetch darkSky web site key
            string secretKey = ConfigurationManager.AppSettings.GetValues("secretKey")[0].ToString();

            // Configure request
            HttpClient client = new HttpClient();
            string latitudeString = Latitude.ToString().Replace(",", ".");
            string longitudeString = Longitude.ToString().Replace(",", ".");
            string requestUri = $"{link}/{secretKey}/{latitudeString},{longitudeString}?lang=pt&units=si";

            // Execute rquest and get response
            HttpResponseMessage response = await client.GetAsync(requestUri);
            client.Dispose();

            // Check the response success status
            if (response.IsSuccessStatusCode == false)
            {
                GotDataEventHandler(false, null);
                return;
            }

            // Process the response
            string data = await response.Content.ReadAsStringAsync();
            Console.WriteLine(data);

            DarkSky DarkSkyData = JsonConvert.DeserializeObject<DarkSky>(data);
            GotDataEventHandler(this, new DataLayerEventArgs<DarkSky>(DarkSkyData));
        }
    }
}
