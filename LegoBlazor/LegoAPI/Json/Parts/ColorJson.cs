using Newtonsoft.Json;

namespace LegoAPI.Json.Parts
{
    public class ColorJson
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}