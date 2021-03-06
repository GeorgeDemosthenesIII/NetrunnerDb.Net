﻿using System;
using Newtonsoft.Json;

namespace NetrunnerDb.Net.Responses
{
    public class Sets : BaseRequest
    {

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("number")]
        public int Number { get; set; }

        [JsonProperty("cyclenumber")]
        public int Cyclenumber { get; set; }

        [JsonProperty("available")]
        public string Available { get; set; }

        [JsonProperty("known")]
        public int Known { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        public override string EndPoint(string parameter = "")
        {
            if (!string.IsNullOrWhiteSpace(parameter))
            {
                throw new ArgumentOutOfRangeException("parameter", "Sets does not have a URL parameter");
            }
            return "/api/sets/";
        }
    }
}
