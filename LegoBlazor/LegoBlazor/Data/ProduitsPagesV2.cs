using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Permissions;
using System.Threading.Tasks;
using LegoBlazor.Tools;
using Microsoft.AspNetCore.Mvc.Routing;
using Newtonsoft.Json;

namespace LegoBlazor.Data
{
    public class ProduitsPages : Pages<Set>
    {
        private IEnumerable<ThemeJson> _themes;
        private IEnumerable<SetJson> _sets;

        public ProduitsPages()
        {
            _themes = Themes();
            _sets = Sets();
        }

        public override IEnumerable<Set> GetItems()
        {
            return SetCache.Values;
        }

        public IEnumerable<ThemeJson> Themes()
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

        public IEnumerable<SetJson> Sets()
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
