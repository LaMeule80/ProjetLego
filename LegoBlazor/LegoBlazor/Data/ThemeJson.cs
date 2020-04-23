using Newtonsoft.Json;

namespace LegoBlazor.Data
{
    public class ThemeJson
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}