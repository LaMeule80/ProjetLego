using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Newtonsoft.Json;

namespace LegoBlazor.Data
{
    public abstract class Pages<T> : ModelControl<T>
    {
        public IEnumerable<T> Items { get; set; }

        protected override async Task OnInitializedAsync()
        {
            await base.OnInitializedAsync();
            await Load();
        }

        protected async Task Load()
        {
            Items = GetItems().Result;
        }

        public abstract Task<IEnumerable<T>> GetItems();
    }

    public class ModelControl<T> : ComponentBase, IDisposable
    {
        [Parameter]
        public T Value { get; set; }

        public void Dispose()
        {
        }
    }

    public class ProduitsPages : Pages<Produit>
    {
        public override Task<IEnumerable<Produit>> GetItems()
        {
            return new ProduitService().GetItems();
        }
    }

    public class ProduitsPagesV2 : Pages<Set>
    {
        private IEnumerable<ThemeJson> _themes;
        private IEnumerable<SetJson> _sets;

        public ProduitsPagesV2()
        {
            _themes = Themes();
            _sets = Sets();
        }

        public override Task<IEnumerable<Set>> GetItems()
        {
            var sets = _sets.Select(x => new Set(x, _themes));
            return Task.FromResult(sets);
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
