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
using System.Globalization;
using System.Configuration;
using Models;
using DataLayer;

[assembly: CLSCompliant(true)]
namespace DarkSkyApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private DataLayerDarkSky dataLayerDarkSky;
        private DataLayerLocation dataLayerLocation;

        public MainWindow()
        {
            InitializeComponent();

            dataLayerLocation = new DataLayerLocation();
            dataLayerLocation.GotDataEventHandler += DataLayerLocation_GotData;

            dataLayerDarkSky = new DataLayerDarkSky();
            dataLayerDarkSky.GotDataEventHandler += DataLayerDarkSky_GotData;
        }

        private void WindowMain_Loaded(object sender, RoutedEventArgs e)
        {
            // Default values from config 
            string defaultLatitude = ConfigurationManager.AppSettings.GetValues("DefaultLatitude")[0].ToString();
            string defaultLongitude = ConfigurationManager.AppSettings.GetValues("DefaultLongitude")[0].ToString();
            textBoxLatitude.Text = defaultLatitude;
            textBoxLongitude.Text = defaultLongitude;
        }

        private void ButtonSearchWeather_Click(object sender, RoutedEventArgs e)
        {
            double latitude = textBoxLatitude.Text.ToDoubleCultureFormatted();
            double longitude = textBoxLongitude.Text.ToDoubleCultureFormatted();

            dataLayerDarkSky.SetLocation(latitude, longitude);
            dataLayerDarkSky.GetDataAsync();
        }

        private void ButtonSearchLocation_Click(object sender, RoutedEventArgs e)
        {
            dataLayerLocation.GetDataAsync();
        }

        private void DataLayerDarkSky_GotData(object sender, DataLayerEventArgs<DarkSky> e)
        {
            ClearValues();

            DarkSky darkSky = e.Item;

            if ( darkSky == null)
            {
                return;
            }

            UpdateValues(darkSky);
        }

        private void DataLayerLocation_GotData(object sender, DataLayerEventArgs<IPInfo> e)
        {
            IPInfo iPInfo = e.Item;

            if (iPInfo == null)
            {
                return;
            }

            textBoxLatitude.Text = iPInfo.Latitude.ToStringCultureFormatted();
            textBoxLongitude.Text = iPInfo.Longitude.ToStringCultureFormatted();
        }

        private void ClearValues()
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

        private void UpdateValues(DarkSky darkSky)
        {
            // Tab Currently
            textBoxApparentTemperature.Text = darkSky.Currently.ApparentTemperature.ToStringCultureFormatted();
            textBoxDewPoint.Text = darkSky.Currently.DewPoint.ToStringCultureFormatted();
            textBoxHumidity.Text = darkSky.Currently.Humidity.ToStringCultureFormatted();
            textBoxIcon.Text = darkSky.Currently.Icon;
            textBoxNearestStormDistance.Text = darkSky.Currently.NearestStormDistance.ToStringCultureFormatted();
            textBoxPrecipIntensity.Text = darkSky.Currently.PrecipIntensity.ToStringCultureFormatted();
            textBoxPrecipIntensityError.Text = darkSky.Currently.PrecipIntensityError.ToStringCultureFormatted();
            textBoxPrecipProbability.Text = darkSky.Currently.PrecipProbability.ToStringCultureFormatted();
            textBoxPrecipType.Text = darkSky.Currently.PrecipType;
            textBoxPressure.Text = darkSky.Currently.Pressure.ToStringCultureFormatted();
            textBoxSummary.Text = darkSky.Currently.Summary;
            textBoxTemperature.Text = darkSky.Currently.Temperature.ToStringCultureFormatted();
            textBoxTime.Text = darkSky.Currently.Time.ToDateTime().ToStringCultureFormatted();
            textBoxWindBearing.Text = darkSky.Currently.WindBearing.ToStringCultureFormatted();
            textBoxWindGust.Text = darkSky.Currently.WindGust.ToStringCultureFormatted();
            textBoxWindSpeed.Text = darkSky.Currently.WindSpeed.ToStringCultureFormatted();
            textBoxTimezone.Text = darkSky.Timezone;

            // Tab Daily
            textBoxTimeDaily.Text = darkSky.Daily.Data[0].Time.ToDateTime().ToStringCultureFormatted();
            textBoxIconDaily.Text = darkSky.Daily.Icon;
            textBoxPrecipIntensityDaily.Text = darkSky.Daily.Data[0].PrecipIntensity.ToStringCultureFormatted();
            textBoxPrecipProbabilityDaily.Text = darkSky.Daily.Data[0].PrecipProbability.ToStringCultureFormatted();
            textBoxTemperatureHighDaily.Text = darkSky.Daily.Data[0].TemperatureHigh.ToStringCultureFormatted();
            textBoxDewPointDaily.Text = darkSky.Daily.Data[0].DewPoint.ToStringCultureFormatted();
            textBoxPressureDaily.Text = darkSky.Daily.Data[0].Pressure.ToStringCultureFormatted();
            textBoxWindGustDaily.Text = darkSky.Daily.Data[0].WindGust.ToStringCultureFormatted();
            textBoxSummaryDaily.Text = darkSky.Daily.Summary;
            textBoxTemperatureLowDaily.Text = darkSky.Daily.Data[0].TemperatureLow.ToStringCultureFormatted();
            textBoxTemperatureLowTimeDaily.Text = darkSky.Daily.Data[0].TemperatureLowTime.ToDateTime().ToStringCultureFormatted();
            textBoxTemperatureHighTimeDaily.Text = darkSky.Daily.Data[0].TemperatureHighTime.ToDateTime().ToStringCultureFormatted();
            textBoxTemperatureMax.Text = darkSky.Daily.Data[0].TemperatureMax.ToStringCultureFormatted();
            textBoxTemperatureMaxTime.Text = darkSky.Daily.Data[0].TemperatureMaxTime.ToDateTime().ToStringCultureFormatted();
            textBoxWindSpeedDaily.Text = darkSky.Daily.Data[0].WindSpeed.ToStringCultureFormatted();
            textBoxWindBearingDaily.Text = darkSky.Daily.Data[0].WindBearing.ToStringCultureFormatted();
        }
    }
}
