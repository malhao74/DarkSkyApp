using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarkSkyApp
{
    class DarkSky
    {
        public double latitude;
        public double longitude;
        public string timezone;
        public DarkSkyCurrently currently;
        public DarkSkyMinutely minutely;
        public DarkSkyHourly hourly;
        public DarkSkyDaily daily;
        public Alerts[] alerts;
        public Flags flags;

        public DarkSky(double latitude, double longitude, string timezone, DarkSkyCurrently currently, DarkSkyMinutely minutely, 
            DarkSkyHourly hourly, DarkSkyDaily daily, Alerts[] alerts, Flags flags)
        {
            this.latitude = latitude;
            this.longitude = longitude;
            this.timezone = timezone;
            this.currently = currently;
            this.minutely = minutely;
            this.hourly = hourly;
            this.daily = daily;
            this.alerts = alerts;
            this.flags = flags;
        }
    }

    class DarkSkyCurrently
    {
        public int time;
        public string summary;
        public string icon;
        public double nearestStormDistance;
        public double precipIntensity;
        public double precipIntensityError;
        public double precipProbability;
        public string precipType;
        public double temperature;
        public double apparentTemperature;
        public double dewPoint;
        public double humidity;
        public double pressure;
        public double windSpeed;
        public double windGust;
        public double windBearing;
        public double cloudCover;
        public double uvIndex;
        public double visibility;
        public double ozone;

        public DarkSkyCurrently(int time, string summary, string icon, double nearestStormDistance, double precipIntensity, 
            double precipIntensityError, double precipProbability, string precipType, double temperature, double apparentTemperature, 
            double dewPoint, double humidity, double pressure, double windSpeed, double windGust, double windBearing, double cloudCover, 
            double uvIndex, double visibility, double ozone)
        {
            this.time = time;
            this.summary = summary;
            this.icon = icon;
            this.nearestStormDistance = nearestStormDistance;
            this.precipIntensity = precipIntensity;
            this.precipIntensityError = precipIntensityError;
            this.precipProbability = precipProbability;
            this.precipType = precipType;
            this.temperature = temperature;
            this.apparentTemperature = apparentTemperature;
            this.dewPoint = dewPoint;
            this.humidity = humidity;
            this.pressure = pressure;
            this.windSpeed = windSpeed;
            this.windGust = windGust;
            this.windBearing = windBearing;
            this.cloudCover = cloudCover;
            this.uvIndex = uvIndex;
            this.visibility = visibility;
            this.ozone = ozone;
        }
    }

    class DarkSkyMinutely
    {
        public string summary;
        public string icon;
        public DarkSkyMinutelyData[] data;

        public DarkSkyMinutely(string summary, string icon, DarkSkyMinutelyData[] data)
        {
            this.summary = summary;
            this.icon = icon;
            this.data = data;
        }
    }

    class DarkSkyMinutelyData
    {
        public int time;
        public double precipIntensity;
        public double precipIntensityError;
        public double precipProbability;
        public string precipType;

        public DarkSkyMinutelyData(int time, double precipIntensity, double precipIntensityError, double precipProbability, 
            string precipType)
        {
            this.time = time;
            this.precipIntensity = precipIntensity;
            this.precipIntensityError = precipIntensityError;
            this.precipProbability = precipProbability;
            this.precipType = precipType;
        }
    }

    class DarkSkyHourly
    {
        public string summary;
        public string icon;
        public DarkSkyHourlyData[] data;

        public DarkSkyHourly(string summary, string icon, DarkSkyHourlyData[] data)
        {
            this.summary = summary;
            this.icon = icon;
            this.data = data;
        }
    }

    class DarkSkyHourlyData
    {
        public int time;
        public string summary;
        public string icon;
        public double precipIntensity;
        public double precipProbability;
        public string precipType;
        public double temperature;
        public double apparentTemperature;
        public double dewPoint;
        public double humidity;
        public double pressure;
        public double windSpeed;
        public double windGust;
        public double windBearing;
        public double cloudCover;
        public double uvIndex;
        public double visibility;
        public double ozone;

        public DarkSkyHourlyData(int time, string summary, string icon, double precipIntensity, double precipProbability, 
            string precipType, double temperature, double apparentTemperature, double dewPoint, double humidity, double pressure, 
            double windSpeed, double windGust, double windBearing, double cloudCover, double uvIndex, double visibility, double ozone)
        {
            this.time = time;
            this.summary = summary;
            this.icon = icon;
            this.precipIntensity = precipIntensity;
            this.precipProbability = precipProbability;
            this.precipType = precipType;
            this.temperature = temperature;
            this.apparentTemperature = apparentTemperature;
            this.dewPoint = dewPoint;
            this.humidity = humidity;
            this.pressure = pressure;
            this.windSpeed = windSpeed;
            this.windGust = windGust;
            this.windBearing = windBearing;
            this.cloudCover = cloudCover;
            this.uvIndex = uvIndex;
            this.visibility = visibility;
            this.ozone = ozone;
        }
    }

    class DarkSkyDaily
    {
        public string summary;
        public string icon;
        public DarkSkyDailyData[] data;

        public DarkSkyDaily(string summary, string icon, DarkSkyDailyData[] data)
        {
            this.summary = summary;
            this.icon = icon;
            this.data = data;
        }
    }

    class DarkSkyDailyData
    {
        public int time;
        public string summary;
        public string icon;
        public int sunriseTime;
        public int sunsetTime;
        public double moonPhase;
        public double precipIntensity;
        public double precipIntensityMax;
        public double precipIntensityMaxTime;
        public double precipProbability;
        public string precipType;
        public double temperatureHigh;
        public double temperatureHighTime;
        public double temperatureLow;
        public double temperatureLowTime;
        public double apparentTemperatureHigh;
        public double apparentTemperatureHighTime;
        public double apparentTemperatureLow;
        public double apparentTemperatureLowTime;
        public double dewPoint;
        public double humidity;
        public double pressure;
        public double windSpeed;
        public double windGust;
        public double windGustTime;
        public double windBearing;
        public double cloudCover;
        public double uvIndex;
        public double uvIndexTime;
        public double visibility;
        public double ozone;
        public double temperatureMin;
        public double temperatureMinTime;
        public double temperatureMax;
        public double temperatureMaxTime;
        public double apparentTemperatureHMin;
        public double apparentTemperatureHMinTime;
        public double apparentTemperatureHMax;
        public double apparentTemperatureHMaxTime;

        public DarkSkyDailyData(int time, string summary, string icon, int sunriseTime, int sunsetTime, double moonPhase, 
            double precipIntensity, double precipIntensityMax, double precipIntensityMaxTime, double precipProbability, 
            string precipType, double temperatureHigh, double temperatureHighTime, double temperatureLow, double temperatureLowTime, 
            double apparentTemperatureHigh, double apparentTemperatureHighTime, double apparentTemperatureLow, 
            double apparentTemperatureLowTime, double dewPoint, double humidity, double pressure, double windSpeed, double windGust, 
            double windGustTime, double windBearing, double cloudCover, double uvIndex, double uvIndexTime, double visibility, 
            double ozone, double temperatureMin, double temperatureMinTime, double temperatureMax, double temperatureMaxTime, 
            double apparentTemperatureHMin, double apparentTemperatureHMinTime, double apparentTemperatureHMax, 
            double apparentTemperatureHMaxTime)
        {
            this.time = time;
            this.summary = summary;
            this.icon = icon;
            this.sunriseTime = sunriseTime;
            this.sunsetTime = sunsetTime;
            this.moonPhase = moonPhase;
            this.precipIntensity = precipIntensity;
            this.precipIntensityMax = precipIntensityMax;
            this.precipIntensityMaxTime = precipIntensityMaxTime;
            this.precipProbability = precipProbability;
            this.precipType = precipType;
            this.temperatureHigh = temperatureHigh;
            this.temperatureHighTime = temperatureHighTime;
            this.temperatureLow = temperatureLow;
            this.temperatureLowTime = temperatureLowTime;
            this.apparentTemperatureHigh = apparentTemperatureHigh;
            this.apparentTemperatureHighTime = apparentTemperatureHighTime;
            this.apparentTemperatureLow = apparentTemperatureLow;
            this.apparentTemperatureLowTime = apparentTemperatureLowTime;
            this.dewPoint = dewPoint;
            this.humidity = humidity;
            this.pressure = pressure;
            this.windSpeed = windSpeed;
            this.windGust = windGust;
            this.windGustTime = windGustTime;
            this.windBearing = windBearing;
            this.cloudCover = cloudCover;
            this.uvIndex = uvIndex;
            this.uvIndexTime = uvIndexTime;
            this.visibility = visibility;
            this.ozone = ozone;
            this.temperatureMin = temperatureMin;
            this.temperatureMinTime = temperatureMinTime;
            this.temperatureMax = temperatureMax;
            this.temperatureMaxTime = temperatureMaxTime;
            this.apparentTemperatureHMin = apparentTemperatureHMin;
            this.apparentTemperatureHMinTime = apparentTemperatureHMinTime;
            this.apparentTemperatureHMax = apparentTemperatureHMax;
            this.apparentTemperatureHMaxTime = apparentTemperatureHMaxTime;
        }
    }

    class Alerts
    {
        public string title;
        public int time;
        public int expires;
        public string description;
        public string uri;

        public Alerts(string title, int time, int expires, string description, string uri)
        {
            this.title = title;
            this.time = time;
            this.expires = expires;
            this.description = description;
            this.uri = uri;
        }
    }

    class Flags
    {
        public string units;

        public Flags(string units)
        {
            this.units = units;
        }
    }
}
