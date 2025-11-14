using Terraria.ModLoader;

namespace CSENamelessAfterMutant
{
    public class ChecklistFixer : ModSystem
    {
        public static class Checklist
        {
            public static void Update()
            {
                if (!ModLoader.TryGetMod("BossChecklist", out Mod bossChecklistMod))
                {
                    return;
                }

                ModDefinitions.Fargo.BossChecklistValues["MutantBoss"] = 27f;

                return;
            }
        }
    }
}
