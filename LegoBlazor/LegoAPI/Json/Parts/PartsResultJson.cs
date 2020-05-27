using System.Collections.Generic;
using System.Security.Principal;
using Newtonsoft.Json;

namespace LegoAPI.Json.Parts
{
    public class PartsResultJson
    {
        [JsonProperty("count")]
        public long Count { get; set; }

        [JsonProperty("next")]
        public object Next { get; set; }

        [JsonProperty("previous")]
        public object Previous { get; set; }

        [JsonProperty("results")]
        public List<PartsJson> Results { get; set; }
    }
}
