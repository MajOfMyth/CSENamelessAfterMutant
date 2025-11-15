using Terraria.ModLoader;
using CSENamelessAfterMutant.Common;

namespace CSENamelessAfterMutant
{
    public class CSENamelessAfterMutant : Mod
    {
        //bad puch leave me alone
        //public override void Load()
        public override void PostSetupContent()
        {
            ChecklistFixer.Checklist.Update();
        }
    }
}
