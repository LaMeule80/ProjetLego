using System;
using Newtonsoft.Json;

namespace LegoAPI.Json.Parts
{
    public class PartJson
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("part_url")]
        public Uri PartUrl { get; set; }

        [JsonProperty("part_img_url")]
        public Uri PartImgUrl { get; set; }
    }
}