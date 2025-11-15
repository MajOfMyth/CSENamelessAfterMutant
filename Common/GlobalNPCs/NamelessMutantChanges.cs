using Terraria;
using Terraria.ModLoader;
using ssm.Core;
using NoxusBoss.Content.NPCs.Bosses.NamelessDeity;
using FargowiltasSouls.Content.Bosses.MutantBoss;
using System;

namespace CSENamelessAfterMutant.Common.GlobalNPCs
{
    public class NamelessMutantChanges : GlobalNPC
    {
        public override void SetDefaults(NPC npc)
        {
            if (npc.type == ModContent.NPCType<NamelessDeityBoss>())
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

            //make mutant a lil weaker for balance
            if (npc.type == ModContent.NPCType<MutantBoss>())
            {
                npc.lifeMax = (int)MathF.Round(npc.lifeMax*0.6f);

            }
        }

        public override void ModifyIncomingHit(NPC npc, ref NPC.HitModifiers modifiers)
        {

            if (npc.type == ModContent.NPCType<NamelessDeityBoss>())
            {
                //modifiers.FinalDamage *= 10;
                //this for now
                modifiers.FinalDamage *= 0.3333f;
            }

            if (npc.type == ModContent.NPCType<MutantBoss>())
            {
                modifiers.FinalDamage *= 0.6f;
            }

        }
    }
}
