using Terraria.ModLoader;
using CSEL.Core;

namespace CSENamelessAfterMutant.Common
{
    public class ChecklistFixer : ModSystem
    {
        public static class Checklist
        {
            public static void Update()
            {
                ModCompatibility.SoulsMod.Mod.BossChecklistValues["MutantBoss"] = 27f;
                return;
            }
        }
    }
}
