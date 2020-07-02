using System.Collections.Generic;
using LegoAPI.Json;
using LegoAPI.Json.Parts;
using OutilsBlazor;

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

            var result = Get<SetResultJson>($"{Adresse}/?", param);

            return result.Results;
        }

        public SetJson LireSet(string number)
        {
            var adresse = $"{Adresse}/{number}/?";
            var result = Get<SetJson>(adresse);
            return result;
        }

        public List<PartsJson> LireParts(string number, long numParts)
        {
            List<KeyValuePair<string, object>> param = new List<KeyValuePair<string, object>>();
            param.Add(new KeyValuePair<string, object>("page_size", numParts));
            string adresse = $"{Adresse}/{number}/parts/?";
            var result = Get<PartsResultJson>(adresse, param);
            return result.Results;
        }

        public override string ApiKey => "df134229e22f0dac787fb8ed6973de97";        
        public override string UrlBase => "https://rebrickable.com/api/v3/lego";
        public override string Uri => "sets";
    }
}