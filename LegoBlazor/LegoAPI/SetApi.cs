using System.Collections.Generic;
using System.Reflection;
using LegoAPI.Json;

namespace LegoAPI
{
    public class SetApi : ApiHelper
    {
        public List<SetJson> LireSets(int year)
        {
            return LireSets(year, year);
        }

        public List<SetJson> LireSets(int yearMin, int yearMax)
        {
            List<KeyValuePair<string, object>> param = new List<KeyValuePair<string, object>>();
            param.Add(new KeyValuePair<string, object>("theme_id", 1));
            param.Add(new KeyValuePair<string, object>("min_year", yearMin));
            param.Add(new KeyValuePair<string, object>("max_year", yearMax));

            var result = Get<CallResult>(param);

            return result.Results;
        }

        public override string Uri => "sets";
    }
}