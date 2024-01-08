﻿using FluentWeather.Abstraction.Helpers;
using FluentWeather.QWeatherApi.ApiContracts;
using FluentWeather.QWeatherProvider.Models;
using System;

namespace FluentWeather.QWeatherProvider.Mappers;

public static class DailyForecastItemMapper
{
    public static QWeatherDailyForecast MapToQWeatherDailyForecast(this WeatherDailyResponse.DailyForecastItem item)
    {
        return new QWeatherDailyForecast
        {
            WindDirection = UnitConverter.GetWindDirectionFromAngle(int.Parse(item.Wind360Day)),
            Description = item.TextDay,
            WindDirectionDescription = item.WindDirDay,
            WindScale = item.WindScaleDay,
            WindSpeed = int.Parse(item.WindSpeedDay),
            Humidity = int.Parse(item.Humidity),
            MaxTemperature = int.Parse(item.TempMax),
            MinTemperature = int.Parse(item.TempMin),
            Pressure = int.Parse(item.Pressure),
            Time = DateTime.Parse(item.FxDate),
            Visibility = int.Parse(item.Vis),
            SunRise = DateTime.Parse(item.Sunrise),
            SunSet = DateTime.Parse(item.Sunset),
            CloudAmount = item.Cloud is not "" ? int.Parse(item.Cloud) : null,

            WeatherNight = new QWeatherNight
            {
                Description = item.TextNight,
                WindDirection = UnitConverter.GetWindDirectionFromAngle(int.Parse(item.Wind360Night)),
                WindDirectionDescription = item.WindDirNight,
                WindScale = item.WindScaleNight,
                WindSpeed = int.Parse(item.WindSpeedNight),
            }
        };
    }
}