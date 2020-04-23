using System.Collections.Generic;
using LegoBlazor.Tools;

namespace LegoBlazor.Data
{
    public class ThemesPages : Pages<Theme>
    {
        public override IEnumerable<Theme> GetItems()
        {
            return ThemeCache.Values;
        }
    }
}