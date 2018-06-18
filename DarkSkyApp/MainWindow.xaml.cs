using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DarkSkyApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonProcurar_Click(object sender, RoutedEventArgs e)
        {
            double latitude = Convert.ToDouble(textBoxLatitude.Text);
            double longitude = Convert.ToDouble(textBoxLongitude.Text);

            DataLayer dataLayer = new DataLayer(latitude, longitude);
            dataLayer.DataLayer_GotData += DataLayer_GotData;
            dataLayer.GetDarkSky();
        }

        private void WindowMain_Loaded(object sender, RoutedEventArgs e)
        {
            // Para testes.
            textBoxLatitude.Text = "42,3601";
            textBoxLongitude.Text = "-71,0589";
        }

        private void DataLayer_GotData(bool correuBem, DarkSky darkSky)
        {
            LimpaEcran();

            if (correuBem == false)
            {
                return;
            }

            ActualizaEcran(darkSky);
        }

        private void LimpaEcran()
        {
            // Tab Currently
            textBoxApparentTemperature.Text = "";
            textBoxDewPoint.Text = "";
            textBoxHumidity.Text = "";
            textBoxIcon.Text = "";
            textBoxNearestStormDistance.Text = "";
            textBoxPrecipIntensity.Text = "";
            textBoxPrecipIntensityError.Text = "";
            textBoxPrecipProbability.Text = "";
            textBoxPrecipType.Text = "";
            textBoxPressure.Text = "";
            textBoxSummary.Text = "";
            textBoxTemperature.Text = "";
            textBoxTime.Text = "";
            textBoxWindBearing.Text = "";
            textBoxWindGust.Text = "";
            textBoxWindSpeed.Text = "";
            textBoxTimezone.Text = "";

            // Tab Daily
            textBoxTimeDaily.Text = "";
            textBoxIconDaily.Text = "";
            textBoxPrecipIntensityDaily.Text = "";
            textBoxPrecipProbabilityDaily.Text = "";
            textBoxTemperatureHighDaily.Text = "";
            textBoxDewPointDaily.Text = "";
            textBoxPressureDaily.Text = "";
            textBoxWindGustDaily.Text = "";
            textBoxSummaryDaily.Text = "";
            textBoxTemperatureLowDaily.Text = "";
            textBoxTemperatureLowTimeDaily.Text = "";
            textBoxTemperatureHighTimeDaily.Text = "";
            textBoxTemperatureMax.Text = "";
            textBoxTemperatureMaxTime.Text = "";
            textBoxWindSpeedDaily.Text = "";
            textBoxWindBearingDaily.Text = "";
        }

        private void ActualizaEcran(DarkSky darkSky)
        {
            // Tab Currently
            textBoxApparentTemperature.Text = darkSky.currently.apparentTemperature.ToString();
            textBoxDewPoint.Text = darkSky.currently.dewPoint.ToString();
            textBoxHumidity.Text = darkSky.currently.humidity.ToString();
            textBoxIcon.Text = darkSky.currently.icon;
            textBoxNearestStormDistance.Text = darkSky.currently.nearestStormDistance.ToString();
            textBoxPrecipIntensity.Text = darkSky.currently.precipIntensity.ToString();
            textBoxPrecipIntensityError.Text = darkSky.currently.precipIntensityError.ToString();
            textBoxPrecipProbability.Text = darkSky.currently.precipProbability.ToString();
            textBoxPrecipType.Text = darkSky.currently.precipType;
            textBoxPressure.Text = darkSky.currently.pressure.ToString();
            textBoxSummary.Text = darkSky.currently.summary;
            textBoxTemperature.Text = darkSky.currently.temperature.ToString();
            textBoxTime.Text = ConvertUnixTimeStamp(darkSky.currently.time).ToString();
            textBoxWindBearing.Text = darkSky.currently.windBearing.ToString();
            textBoxWindGust.Text = darkSky.currently.windGust.ToString();
            textBoxWindSpeed.Text = darkSky.currently.windSpeed.ToString();
            textBoxTimezone.Text = darkSky.timezone;

            // Tab Daily
            textBoxTimeDaily.Text = ConvertUnixTimeStamp(darkSky.daily.data[0].time).ToString();
            textBoxIconDaily.Text = darkSky.daily.icon;
            textBoxPrecipIntensityDaily.Text = darkSky.daily.data[0].precipIntensity.ToString();
            textBoxPrecipProbabilityDaily.Text = darkSky.daily.data[0].precipProbability.ToString();
            textBoxTemperatureHighDaily.Text = darkSky.daily.data[0].temperatureHigh.ToString();
            textBoxDewPointDaily.Text = darkSky.daily.data[0].dewPoint.ToString();
            textBoxPressureDaily.Text = darkSky.daily.data[0].pressure.ToString();
            textBoxWindGustDaily.Text = darkSky.daily.data[0].windGust.ToString();
            textBoxSummaryDaily.Text = darkSky.daily.summary;
            textBoxTemperatureLowDaily.Text = darkSky.daily.data[0].temperatureLow.ToString();
            textBoxTemperatureLowTimeDaily.Text = ConvertUnixTimeStamp(darkSky.daily.data[0].temperatureLowTime).ToString();
            textBoxTemperatureHighTimeDaily.Text = ConvertUnixTimeStamp(darkSky.daily.data[0].temperatureHighTime).ToString();
            textBoxTemperatureMax.Text = darkSky.daily.data[0].temperatureMax.ToString();
            textBoxTemperatureMaxTime.Text = ConvertUnixTimeStamp(darkSky.daily.data[0].temperatureMaxTime).ToString();
            textBoxWindSpeedDaily.Text = darkSky.daily.data[0].windSpeed.ToString();
            textBoxWindBearingDaily.Text = darkSky.daily.data[0].windBearing.ToString();
        }
        // Conversão de UNIX timestamp.
        private DateTime ConvertUnixTimeStamp(int unixTimeStamp)
        {
            DateTime dateTime = new DateTime(1970, 1, 1);
            dateTime = dateTime.AddSeconds(unixTimeStamp);
            return dateTime;
        }
    }
}
