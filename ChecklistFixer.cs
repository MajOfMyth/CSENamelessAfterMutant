using Terraria.ModLoader;
using ssm.Core;

namespace CSENamelessAfterMutant
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
