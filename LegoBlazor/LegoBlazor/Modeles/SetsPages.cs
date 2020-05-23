using System.Collections.Generic;
using System.Linq;
using LegoBlazor.Data;
using LegoBlazor.Tools;
using Microsoft.AspNetCore.Components;

namespace LegoBlazor.Modeles
{
    public class SetsPages : Pages<Set>
    {
        [Parameter]
        public int Year { get; set; }

        public override IEnumerable<Set> GetItems()
        {
            return SetCache.Values.Where(x => x.Year == Year);
        }
    }
}
