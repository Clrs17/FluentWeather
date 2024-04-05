﻿using FluentWeather.Abstraction.Interfaces.Weather;
using FluentWeather.Abstraction.Models;
using FluentWeather.Uwp.QWeatherProvider.Helpers;

namespace FluentWeather.Uwp.QWeatherProvider.Models;

public sealed class QWeatherHourlyForecast :WeatherHourlyBase,  ICloudAmount
{
    public int? CloudAmount { get; set; }
}