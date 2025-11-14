using Terraria.ModLoader;
using CSENamelessAfterMutant.Common;

namespace CSENamelessAfterMutant
{
    public class CSENamelessAfterMutant : Mod
    {
        public override void Load()
        {
            ChecklistFixer.Checklist.Update();
        }
    }
}
