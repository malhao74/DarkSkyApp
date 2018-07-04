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
{
    /// <summary>
    /// Fetch location information from IP info API
    /// </summary>
    class DataLayerLocation : IDataLayerInterface<IPInfo>
    {
        public event EventHandler<DataLayerEventArgs<IPInfo>> GotDataEventHandler;

        public async void GetDataAsync()
        {
            // Fetch IpInfo web site key
            string secretKey = ConfigurationManager.AppSettings.GetValues("ipinfoKey")[0].ToString();

            // Configure request
            HttpClient client = new HttpClient();
            string requestUri = $"http://ipinfo.io?token={secretKey}";

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

            IPInfo ipInfo = JsonConvert.DeserializeObject<IPInfo>(data);

            GotDataEventHandler(null, new DataLayerEventArgs<IPInfo>(ipInfo));
        }
    }
}
