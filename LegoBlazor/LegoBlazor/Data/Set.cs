using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace LegoBlazor.Data
{
    public class Set
    {
        public Set(
            SetJson set, 
            IEnumerable<ThemeJson> themes)
        {
            NumParts = set.NumParts;
            SetNum = set.SetNum;
            Year = set.Year;
            Name = set.Name;
            var theme = themes.First(x => x.Id == set.ThemeId);
            ThemeId = theme.Id;
            Theme = theme.Name;
            SetImgUrl = set.SetImgUrl;
            SetUrl = set.SetUrl;
        }
        
        public string SetNum { get; set; }

        public string Name { get; set; }

        public long Year { get; set; }

        public long ThemeId { get; set; }

        public long NumParts { get; set; }

        public Uri SetImgUrl { get; set; }

        public Uri SetUrl { get; set; }

        public DateTimeOffset? LastModifiedDt { get; set; }

        public string Theme { get; set; }
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
        public DateTimeOffset? LastModifiedDt { get; set; }
    }

    public class ThemeJson
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}