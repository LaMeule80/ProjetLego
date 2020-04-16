using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace LegoBlazor.Data
{
    public class ProduitService
    {
        public Task<IEnumerable<Produit>> GetItems()
        {
            List<Produit> prods = new List<Produit>();
            prods.Add(new Produit(1, 42097, "La grue araignée", 920, 1));
            prods.Add(new Produit(2, 42082, "La grue tout-terrain", 4057, 1));
            prods.Add(new Produit(3, 42105, "Le catamaran   ", 404, 2));
            return Task.FromResult(prods.AsEnumerable());
        }
    }

    public class ProduitServiceV2
    {
        public Task<IEnumerable<SetJson>> GetItems()
        {
            List<SetJson> result;
            var file = Path.Combine(Directory.GetCurrentDirectory(), "Data", "Sets.json");
            using (StreamReader r = new StreamReader(file))
            {
                string json = r.ReadToEnd();
                result = JsonConvert.DeserializeObject<List<SetJson>>(json);
            }

            return Task.FromResult(result.AsEnumerable());
        }
    }
}
