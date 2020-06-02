using System.Collections.Generic;
using Newtonsoft.Json;

namespace LegoAPI.Json
{
    public class SetResultJson
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
}
