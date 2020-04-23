using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;

namespace LegoBlazor.Data
{
    public static class ThemeCache
    {
        private static Dictionary<long, Theme> _values = new Dictionary<long, Theme>();

        static ThemeCache()
        {
            Load();
        }

        private static void Load()
        {
            var theme = Themes();

            foreach (var item in theme)
            {
                _values.Add(item.Id, new Theme(item));
            }
        }

        public static IEnumerable<Theme> Values => _values.Select(x => x.Value);

        public static Theme GetValue(long key)
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
    }
}