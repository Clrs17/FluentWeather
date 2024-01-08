﻿using FluentWeather.Abstraction.Interfaces.Weather;
using System;
using System.Collections.Generic;
using System.Text;
namespace FluentWeather.Abstraction.Models;
public class WeatherCacheBase
{
    public virtual required List<WeatherDailyBase> DailyForecasts { get; set; }
    public virtual required List<WeatherHourlyBase> HourlyForecasts { get; set; }
    public virtual List<WeatherWarningBase>? Warnings { get; set; }
    public virtual required WeatherNowBase WeatherNow { get; set; }
    public virtual DateTime SunRise { get; set; }
    public virtual DateTime SunSet { get; set; }
    public virtual required GeolocationBase Location { get; set; }
    public virtual List<IndicesBase>? Indices { get; set; }
    public virtual PrecipitationBase? Precipitation { get; set; }
    public virtual AirConditionBase? AirCondition { get; set; }
    public virtual required DateTime UpdatedTime { get; set; }
}