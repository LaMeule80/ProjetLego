using Newtonsoft.Json;

namespace LegoAPI.Json.Parts
{
    public class PartsJson
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("part")]
        public PartJson Part { get; set; }

        [JsonProperty("color")]
        public ColorJson Color { get; set; }

        [JsonProperty("quantity")]
        public long Quantity { get; set; }
    }
}