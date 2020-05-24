using System.Collections.Generic;
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

            var result = Get<CallResult>(AdresseWithKey, param);

            return result.Results;
        }

        public SetJson LireSet(string number)
        {
            var adresse = $"{AdresseWithoutKey}{number}/?key={ApiKey}";
            var result = Get<SetJson>(adresse);
            return result;
        }

        public override string Uri => "sets";
    }
}