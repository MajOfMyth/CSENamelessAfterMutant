using Terraria.ModLoader;

namespace CSENamelessAfterMutant
{
    public class ChecklistFixer : ModSystem
    {
        public static class Checklist
        {
            public static void Update()
            {
                ModDefinitions.Fargo.BossChecklistValues["MutantBoss"] = 27f;
                return;
            }
        }
    }
}
