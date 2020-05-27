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
            var result = setApi.LireParts("42105-1");
            Assert.True(result.Count > 0);
        }
    }
}
