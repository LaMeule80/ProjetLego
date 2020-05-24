using System.Collections.Generic;
using System.Linq;
using LegoAPI;
using LegoAPI.Json;
using LegoBlazor.API;
using Xunit;

namespace LegoAPITest
{
    public class SetTestUnitaires
    {
        [Fact]
        public void CallApiSetV1()
        {
            string api = "https://rebrickable.com/api/v3/lego/sets/?key=df134229e22f0dac787fb8ed6973de97&theme_id=1&min_year=2020&max_year=2020";
            SyncHttpClient client = new SyncHttpClient();
            var result = client.Get<CallResult>(api);
            Assert.True(result.Results.Count > 0);
            Assert.True(result.Results.Count(x => x.ThemeId == 1) > 0);
        }

        [Fact]
        public void CallApiSetV2()
        {
            SetApi setApi = new SetApi();
            var result = setApi.LireSets(2020);
            Assert.True(result.Count > 0);
            Assert.True(result.Count(x => x.ThemeId == 1) > 0);
        }

        [Fact]
        public void ParametersV1()
        {
            List<KeyValuePair<string, object>> keys = new List<KeyValuePair<string, object>>();
            keys.Add(new KeyValuePair<string, object>("param1", 1));
            keys.Add(new KeyValuePair<string, object>("param2", "test"));

            string result = null;
            keys.ForEach(x => result += $"&{x.Key}={x.Value}");

            Assert.True(!string.IsNullOrEmpty(result));
        }
    }
}
