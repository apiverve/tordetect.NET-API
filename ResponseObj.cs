using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace APIVerve
{
public class ipDetails
{
    [JsonProperty("range")]
    public int[] range { get; set; }

    [JsonProperty("country")]
    public string country { get; set; }

    [JsonProperty("region")]
    public string region { get; set; }

    [JsonProperty("timezone")]
    public string timezone { get; set; }

}

public class data
{
    [JsonProperty("ipAddress")]
    public string ipAddress { get; set; }

    [JsonProperty("isTor")]
    public bool isTor { get; set; }

    [JsonProperty("ipDetails")]
    public ipDetails ipDetails { get; set; }

    [JsonProperty("parsed")]
    public bool parsed { get; set; }

}

public class ResponseObj
{
    [JsonProperty("status")]
    public string status { get; set; }

    [JsonProperty("error")]
    public object error { get; set; }

    [JsonProperty("data")]
    public data data { get; set; }

    [JsonProperty("code")]
    public int code { get; set; }

}

}
