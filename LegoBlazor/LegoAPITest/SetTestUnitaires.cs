using System.Collections.Generic;
using System.Linq;
using LegoAPI;
using LegoAPI.Json;
using LegoAPI.Json.Parts;
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
            var result = client.Get<SetResultJson>(api);
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
        public void CallApiSetV3()
        {
            SetApi setApi = new SetApi();
            var result = setApi.LireSet("42101-1");
            Assert.True(result.Name == "Buggy");
        }

        [Fact]
        public void CallApiPartV1()
        {
            string api = "https://rebrickable.com/api/v3/lego/sets/42105-1/parts/?key=df134229e22f0dac787fb8ed6973de97";
            SyncHttpClient client = new SyncHttpClient();
            var result = client.Get<PartsResultJson>(api);
            Assert.True(result.Results.Count > 0);
        }

        [Fact]
        public void CallApiPartV2()
        {
            SetApi setApi = new SetApi();
            var result = setApi.LireParts("42105-1", 404);
            Assert.True(result.Count > 0);
        }

        [Fact]
        public void CallApiPartV3()
        {
            string api = "https://rebrickable.com/api/v3/lego/sets/42064-1/parts/?key=df134229e22f0dac787fb8ed6973de97";
            List<PartsJson> parts = new List<PartsJson>();
            object next = api;
            int idx = 0;
            while (true)
            {
                idx++;
                SyncHttpClient client = new SyncHttpClient();
                var result = client.Get<PartsResultJson>(next.ToString());
                parts.AddRange(result.Results);
                if (result.Next == null)
                    break;
                next = result.Next;
            }
            
            Assert.True(parts.Count == 182);
            Assert.True(parts.Sum(x => x.Quantity) == 1358);
        }

        [Fact]
        public void CallApiPartV4()
        {
            SetApi setApi = new SetApi();
            var result = setApi.LireParts("42064-1", 182);
            Assert.True(result.Count == 182);
            Assert.True(result.Sum(x => x.Quantity) == 1358);
        }
    }
}
