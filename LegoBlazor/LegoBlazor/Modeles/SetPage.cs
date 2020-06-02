using LegoAPI;
using LegoBlazor.Data;
using OutilsBlazor;

namespace LegoBlazor.Modeles
{
    public class SetPage : Page<Set>
    {
        public override Set GetItem()
        {
            return new Set(new SetApi().LireSet(SetNum));
        }
    }
}