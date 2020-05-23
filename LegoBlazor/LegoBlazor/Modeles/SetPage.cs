using LegoBlazor.Data;
using LegoBlazor.Tools;

namespace LegoBlazor.Modeles
{
    public class SetPage : Page<Set>
    {
        public override Set GetItem()
        {
            return SetCache.GetValue(Id);
        }
    }
}