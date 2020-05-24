using System;
using System.Collections.Generic;
using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace LegoAPI.Json
{
    public partial class CallResult
    {
        [JsonProperty("count")]
        public long Count { get; set; }

        [JsonProperty("next")]
        public object Next { get; set; }

        [JsonProperty("previous")]
        public object Previous { get; set; }

        [JsonProperty("results")]
        public List<SetJson> Results { get; set; }
    }

    public class SetJson
    {
        [JsonProperty("set_num")]
        public string SetNum { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("year")]
        public long Year { get; set; }

        [JsonProperty("theme_id")]
        public long ThemeId { get; set; }

        [JsonProperty("num_parts")]
        public long NumParts { get; set; }

        [JsonProperty("set_img_url")]
        public Uri SetImgUrl { get; set; }

        [JsonProperty("set_url")]
        public Uri SetUrl { get; set; }

        [JsonProperty("last_modified_dt")]
        public DateTimeOffset LastModifiedDt { get; set; }
    }
}
