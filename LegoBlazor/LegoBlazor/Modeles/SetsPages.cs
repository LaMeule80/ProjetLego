using System;
using System.Collections.Generic;
using System.Linq;
using LegoAPI;
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
            SetApi api = new SetApi();
            return api.LireSets(Year).Select(x => new Set(x)).ToList();
        }
    }
}
