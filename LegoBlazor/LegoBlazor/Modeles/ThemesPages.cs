using System.Collections.Generic;
using LegoBlazor.Data;
using LegoBlazor.Tools;

namespace LegoBlazor.Modeles
{
    public class ThemesPages : Pages<Theme>
    {
        public override IEnumerable<Theme> GetItems()
        {
            return ThemeCache.Values;
        }
    }
}