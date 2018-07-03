using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Models
{
    /// <summary>
    /// Classes to map the json information from the DarkSky API
    /// </summary>
    class DarkSky
    {
        public double Latitude { get; }
        public double Longitude { get; }
        public string Timezone { get; }
        public DarkSkyCurrently Currently { get; }
        public DarkSkyMinutely Minutely { get; }
        public DarkSkyHourly Hourly { get; }
        public DarkSkyDaily Daily { get; }
        public Alerts[] Alerts { get; }
        public Flags Flags { get; }

        public DarkSky(double latitude, double longitude, string timezone, DarkSkyCurrently currently, DarkSkyMinutely minutely, 
            DarkSkyHourly hourly, DarkSkyDaily daily, Alerts[] alerts, Flags flags)
        {
            Latitude = latitude;
            Longitude = longitude;
            Timezone = timezone;
            Currently = currently;
            Minutely = minutely;
            Hourly = hourly;
            Daily = daily;
            Alerts = alerts;
            Flags = flags;
        }
    }

    class DarkSkyCurrently
    {
        public int Time { get; }
        public string Summary { get; }
        public string Icon { get; }
        public double NearestStormDistance { get; }
        public double PrecipIntensity { get; }
        public double PrecipIntensityError { get; }
        public double PrecipProbability { get; }
        public string PrecipType { get; }
        public double Temperature { get; }
        public double ApparentTemperature { get; }
        public double DewPoint { get; }
        public double Humidity { get; }
        public double Pressure { get; }
        public double WindSpeed { get; }
        public double WindGust { get; }
        public double WindBearing { get; }
        public double CloudCover { get; }
        public double UvIndex { get; }
        public double Visibility { get; }
        public double Ozone { get; }

        public DarkSkyCurrently(int time, string summary, string icon, double nearestStormDistance, double precipIntensity, 
            double precipIntensityError, double precipProbability, string precipType, double temperature, double apparentTemperature, 
            double dewPoint, double humidity, double pressure, double windSpeed, double windGust, double windBearing, double cloudCover, 
            double uvIndex, double visibility, double ozone)
        {
            Time = time;
            Summary = summary;
            Icon = icon;
            NearestStormDistance = nearestStormDistance;
            PrecipIntensity = precipIntensity;
            PrecipIntensityError = precipIntensityError;
            PrecipProbability = precipProbability;
            PrecipType = precipType;
            Temperature = temperature;
            ApparentTemperature = apparentTemperature;
            DewPoint = dewPoint;
            Humidity = humidity;
            Pressure = pressure;
            WindSpeed = windSpeed;
            WindGust = windGust;
            WindBearing = windBearing;
            CloudCover = cloudCover;
            UvIndex = uvIndex;
            Visibility = visibility;
            Ozone = ozone;
        }
    }

    class DarkSkyMinutely
    {
        public string Summary { get; }
        public string Icon { get; }
        public DarkSkyMinutelyData[] Data { get; }

        public DarkSkyMinutely(string summary, string icon, DarkSkyMinutelyData[] data)
        {
            this.Summary = summary;
            this.Icon = icon;
            this.Data = data;
        }
    }

    class DarkSkyMinutelyData
    {
        public int Time { get; }
        public double PrecipIntensity { get; }
        public double PrecipIntensityError { get; }
        public double PrecipProbability { get; }
        public string PrecipType { get; }

        public DarkSkyMinutelyData(int time, double precipIntensity, double precipIntensityError, double precipProbability, 
            string precipType)
        {
            Time = time;
            PrecipIntensity = precipIntensity;
            PrecipIntensityError = precipIntensityError;
            PrecipProbability = precipProbability;
            PrecipType = precipType;
        }
    }

    class DarkSkyHourly
    {
        public string Summary { get; }
        public string Icon { get; }
        public DarkSkyHourlyData[] Data { get; }

        public DarkSkyHourly(string summary, string icon, DarkSkyHourlyData[] data)
        {
            this.Summary = summary;
            this.Icon = icon;
            this.Data = data;
        }
    }

    class DarkSkyHourlyData
    {
        public int Time { get; }
        public string Summary { get; }
        public string Icon { get; }
        public double PrecipIntensity { get; }
        public double PrecipProbability { get; }
        public string PrecipType { get; }
        public double Temperature { get; }
        public double ApparentTemperature { get; }
        public double DewPoint { get; }
        public double Humidity { get; }
        public double Pressure { get; }
        public double WindSpeed { get; }
        public double WindGust { get; }
        public double WindBearing { get; }
        public double CloudCover { get; }
        public double UvIndex { get; }
        public double Visibility { get; }
        public double Ozone { get; }

        public DarkSkyHourlyData(int time, string summary, string icon, double precipIntensity, double precipProbability, 
            string precipType, double temperature, double apparentTemperature, double dewPoint, double humidity, double pressure, 
            double windSpeed, double windGust, double windBearing, double cloudCover, double uvIndex, double visibility, double ozone)
        {
            Time = time;
            Summary = summary;
            Icon = icon;
            PrecipIntensity = precipIntensity;
            PrecipProbability = precipProbability;
            PrecipType = precipType;
            Temperature = temperature;
            ApparentTemperature = apparentTemperature;
            DewPoint = dewPoint;
            Humidity = humidity;
            Pressure = pressure;
            WindSpeed = windSpeed;
            WindGust = windGust;
            WindBearing = windBearing;
            CloudCover = cloudCover;
            UvIndex = uvIndex;
            Visibility = visibility;
            Ozone = ozone;
        }
    }

    class DarkSkyDaily
    {
        public string Summary { get; }
        public string Icon { get; }
        public DarkSkyDailyData[] Data { get; }

        public DarkSkyDaily(string summary, string icon, DarkSkyDailyData[] data)
        {
            Summary = summary;
            Icon = icon;
            Data = data;
        }
    }

    class DarkSkyDailyData
    {
        public int Time { get; }
        public string Summary { get; }
        public string Icon { get; }
        public int SunriseTime { get; }
        public int SunsetTime { get; }
        public double MoonPhase { get; }
        public double PrecipIntensity { get; }
        public double PrecipIntensityMax { get; }
        public int PrecipIntensityMaxTime { get; }
        public double PrecipProbability { get; }
        public string PrecipType { get; }
        public double TemperatureHigh { get; }
        public int TemperatureHighTime { get; }
        public double TemperatureLow { get; }
        public int TemperatureLowTime { get; }
        public double ApparentTemperatureHigh { get; }
        public int ApparentTemperatureHighTime { get; }
        public double ApparentTemperatureLow { get; }
        public int ApparentTemperatureLowTime { get; }
        public double DewPoint { get; }
        public double Humidity { get; }
        public double Pressure { get; }
        public double WindSpeed { get; }
        public double WindGust { get; }
        public double WindGustTime { get; }
        public double WindBearing { get; }
        public double CloudCover { get; }
        public double UvIndex { get; }
        public double UvIndexTime { get; }
        public double Visibility { get; }
        public double Ozone { get; }
        public double TemperatureMin { get; }
        public int TemperatureMinTime { get; }
        public double TemperatureMax { get; }
        public int TemperatureMaxTime { get; }
        public double ApparentTemperatureHMin { get; }
        public int ApparentTemperatureHMinTime { get; }
        public double ApparentTemperatureHMax { get; }
        public int ApparentTemperatureHMaxTime { get; }

        public DarkSkyDailyData(int time, string summary, string icon, int sunriseTime, int sunsetTime, double moonPhase, 
            double precipIntensity, double precipIntensityMax, int precipIntensityMaxTime, double precipProbability, 
            string precipType, double temperatureHigh, int temperatureHighTime, double temperatureLow, int temperatureLowTime, 
            double apparentTemperatureHigh, int apparentTemperatureHighTime, double apparentTemperatureLow,
            int apparentTemperatureLowTime, double dewPoint, double humidity, double pressure, double windSpeed, double windGust, 
            double windGustTime, double windBearing, double cloudCover, double uvIndex, double uvIndexTime, double visibility, 
            double ozone, double temperatureMin, int temperatureMinTime, double temperatureMax, int temperatureMaxTime, 
            double apparentTemperatureHMin, int apparentTemperatureHMinTime, double apparentTemperatureHMax,
            int apparentTemperatureHMaxTime)
        {
            Time = time;
            Summary = summary;
            Icon = icon;
            SunriseTime = sunriseTime;
            SunsetTime = sunsetTime;
            MoonPhase = moonPhase;
            PrecipIntensity = precipIntensity;
            PrecipIntensityMax = precipIntensityMax;
            PrecipIntensityMaxTime = precipIntensityMaxTime;
            PrecipProbability = precipProbability;
            PrecipType = precipType;
            TemperatureHigh = temperatureHigh;
            TemperatureHighTime = temperatureHighTime;
            TemperatureLow = temperatureLow;
            TemperatureLowTime = temperatureLowTime;
            ApparentTemperatureHigh = apparentTemperatureHigh;
            ApparentTemperatureHighTime = apparentTemperatureHighTime;
            ApparentTemperatureLow = apparentTemperatureLow;
            ApparentTemperatureLowTime = apparentTemperatureLowTime;
            DewPoint = dewPoint;
            Humidity = humidity;
            Pressure = pressure;
            WindSpeed = windSpeed;
            WindGust = windGust;
            WindGustTime = windGustTime;
            WindBearing = windBearing;
            CloudCover = cloudCover;
            UvIndex = uvIndex;
            UvIndexTime = uvIndexTime;
            Visibility = visibility;
            Ozone = ozone;
            TemperatureMin = temperatureMin;
            TemperatureMinTime = temperatureMinTime;
            TemperatureMax = temperatureMax;
            TemperatureMaxTime = temperatureMaxTime;
            ApparentTemperatureHMin = apparentTemperatureHMin;
            ApparentTemperatureHMinTime = apparentTemperatureHMinTime;
            ApparentTemperatureHMax = apparentTemperatureHMax;
            ApparentTemperatureHMaxTime = apparentTemperatureHMaxTime;
        }
    }

    class Alerts
    {
        public string Title { get; }
        public int Time { get; }
        public int Expires { get; }
        public string Description { get; }
        public string Uri { get; }

        public Alerts(string title, int time, int expires, string description, string uri)
        {
            Title = title;
            Time = time;
            Expires = expires;
            Description = description;
            Uri = uri;
        }
    }

    class Flags
    {
        public string Units { get; }

        public Flags(string units)
        {
            Units = units;
        }
    }
}
