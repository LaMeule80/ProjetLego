using LegoBlazor.Tools;

namespace LegoBlazor.Data
{
    public class SetPage : Page<Set>
    {
        public override Set GetItem()
        {
            return SetCache.GetValue(Id);
        }
    }
}