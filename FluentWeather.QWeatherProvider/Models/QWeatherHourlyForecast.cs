﻿using System;
using FluentWeather.Abstraction.Interfaces.Weather;
using FluentWeather.Abstraction.Models;
using FluentWeather.QWeatherProvider.Helpers;

namespace FluentWeather.QWeatherProvider.Models;

public sealed class QWeatherHourlyForecast :WeatherHourlyBase,  ICloudAmount
{
    public override WeatherCode WeatherType => WeatherTypeConverter.GetWeatherTypeByDescription(Description);
    public int? CloudAmount { get; set; }
}