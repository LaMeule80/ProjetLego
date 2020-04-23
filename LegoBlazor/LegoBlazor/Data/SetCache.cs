using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using Newtonsoft.Json;

namespace LegoBlazor.Data
{
    public static class SetCache
    {
        private static Dictionary<Guid, Set> _values = new Dictionary<Guid, Set>();

        static SetCache()
        {
            Load();
        }

        private static void Load()
        {
            var theme = Themes();
            var set = Sets();

            foreach (var item in set)
            {
                var key = Guid.NewGuid();
                var t = new Tuple<Guid, Set>(key, new Set(key, item, theme));
                _values.Add(key, t.Item2);
            }
        }

        public static IEnumerable<Set> Values => _values.Select(x => x.Value);

        public static Set GetValue(Guid key)
        {
            return _values[key];
        }

        public static IEnumerable<ThemeJson> Themes()
        {
            List<ThemeJson> result;
            var file = Path.Combine(Directory.GetCurrentDirectory(), "Data", "Themes.json");
            using (StreamReader r = new StreamReader(file))
            {
                string json = r.ReadToEnd();
                result = JsonConvert.DeserializeObject<List<ThemeJson>>(json);
            }

            return result;
        }

        public static IEnumerable<SetJson> Sets()
        {
            List<SetJson> result;
            var file = Path.Combine(Directory.GetCurrentDirectory(), "Data", "Sets.json");
            using (StreamReader r = new StreamReader(file))
            {
                string json = r.ReadToEnd();
                result = JsonConvert.DeserializeObject<List<SetJson>>(json);
            }

            return result.AsEnumerable();
        }
    }
}