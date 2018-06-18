﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;

namespace DarkSkyApp
{

    class DataLayer
    {
        #region Delaracao de variaveis
        private readonly string secretKey = "2c68501c5eb8584a079981e6506effd6";
        private readonly string link = "https://api.darksky.net/forecast";

        public readonly double latitude;
        public readonly double longitude;

        public DarkSky darkSky;

        public delegate void Got_Data(bool correuTudoBem, DarkSky darkSky);
        public event Got_Data DataLayer_GotData;
        #endregion

        public DataLayer(double latitudeNew, double longitudeNew)
        {
            latitude = latitudeNew;
            longitude = longitudeNew;
        }

        public async void GetDarkSky()
        {
            HttpClient client = new HttpClient();
            string latitudeString = latitude.ToString().Replace(",", ".");
            string longitudeString = longitude.ToString().Replace(",", ".");
            string requestUri = $"{link}/{secretKey}/{latitudeString},{longitudeString}";
            HttpResponseMessage response = await client.GetAsync(requestUri);
            client.Dispose();

            if (response.IsSuccessStatusCode == false)
            {
                DataLayer_GotData(false, null);
                return;
            }
            string resposta = await response.Content.ReadAsStringAsync();
            Console.WriteLine(resposta);

            darkSky = JsonConvert.DeserializeObject<DarkSky>(resposta);
            DataLayer_GotData(true, darkSky);
        }
    }
}
