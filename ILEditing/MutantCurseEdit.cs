using FargowiltasSouls.Content.Items.Summons;
using MonoMod.RuntimeDetour;
using System;
using System.Reflection;
using Terraria;
using Terraria.ModLoader;

namespace CSENamelessAfterMutant.ILEditing
{
    public class MutantCurseEdit : ModSystem
    {
        private static Hook hook = null;

        public override void Load()
        {
            if (ModLoader.TryGetMod("ssm", out Mod CSE))
            {

                Type t = CSE.Code.GetType("ssm.Calamity.CalDlcItems");
                MethodInfo original = t.GetMethod("CanUseItem", BindingFlags.Public | BindingFlags.Instance);

                hook = new Hook(original, detour);
                
            }
        }

        public override void Unload()
        {
            hook?.Dispose();
            hook = null;
        }

        private static bool detour(Func<GlobalItem, Item, Player, bool> orig, GlobalItem self, Item item, Player player)
        {
            //i seriously have no idea why this doesnt work
            if (item.type == ModContent.ItemType<MutantsCurse>())
            {
                return true;
            }

            return orig(self, item, player);
        }

    }
}
