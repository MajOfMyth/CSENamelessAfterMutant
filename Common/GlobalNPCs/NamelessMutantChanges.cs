using Terraria;
using Terraria.ModLoader;
using ssm.Core;

namespace CSENamelessAfterMutant.Common.GlobalNPCs
{
    public class NamelessMutantChanges : GlobalNPC
    {
        public override void SetDefaults(NPC npc)
        {
            if (npc.type == ModCompatibility.WrathoftheGods.NamelessDeityBoss.Type)
            {

                float multiplier = 0;

                if (ModCompatibility.Thorium.Loaded) { multiplier += 3f; }
                if (ModCompatibility.SacredTools.Loaded) { multiplier += 5f; }
                if (ModCompatibility.Homeward.Loaded) { multiplier += 2f; }
                if (ModCompatibility.Goozma.Loaded) { multiplier += 1f; }
                if (ModCompatibility.Catalyst.Loaded) { multiplier += 1f; }
                if (ModCompatibility.Infernum.Loaded) { multiplier += 1f; }

                npc.lifeMax = (int)(25000000 + (1000000 * multiplier));
                
            }
        }
    }
}
