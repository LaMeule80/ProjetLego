using System.Collections.Generic;
using System.Linq;
using LegoBlazor.Data;
using Microsoft.AspNetCore.Components;
using OutilsBlazor;

namespace LegoBlazor.Modeles
{
    public class SetsPages : Pages<Set>
    {
        [Parameter]
        public int Year { get; set; }

        public override List<Set> GetItems()
        {
            return SetCache.Values.Where(x => x.Year == Year).ToList();
        }
    }
}
