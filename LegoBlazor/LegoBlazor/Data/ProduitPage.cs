using LegoBlazor.Tools;

namespace LegoBlazor.Data
{
    public class ProduitPage : Page<Set>
    {
        public override Set GetItem()
        {
            return SetCache.GetValue(Id);
        }
    }
}