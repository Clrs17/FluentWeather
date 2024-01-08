﻿namespace FluentWeather.Abstraction.Models;

public class GeolocationBase
{
    /// <summary>
    /// 地区名
    /// </summary>
    public required string Name { get; set; }
    /// <summary>
    /// 经度
    /// </summary>
    public required double Longitude{ get; set; }
    /// <summary>
    /// 纬度
    /// </summary>
    public required double Latitude { get; set; }
    /// <summary>
    /// 行政区
    /// </summary>
    public string? AdmDistrict { get; set; }
    public GeolocationBase(string name, double lon, double lat)
    {
        Name = name;
        Longitude = lon;
        Latitude = lat;
    }
    public GeolocationBase()
    {
          
    }
}