﻿using FluentWeather.Abstraction.Interfaces.Weather;
using FluentWeather.Abstraction.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace FluentWeather.QWeatherProvider.Models
{
    public sealed class QAirCondition:AirConditionBase,IAirPollutants
    {
        public string Link{ get; set; }
    }
}
