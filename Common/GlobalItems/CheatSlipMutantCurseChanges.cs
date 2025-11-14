using FargowiltasSouls.Content.Items.Summons;
using NoxusBoss.Content.Items;
using Terraria.ModLoader;
using Terraria;
using System.Collections.Generic;

namespace CSENamelessAfterMutant.Common.GlobalItems
{
    public class CheatSlipMutantCurseChanges : GlobalItem
    {
        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            if (item.type == ModContent.ItemType<CheatPermissionSlip>())
            {
                //what?
                tooltips.RemoveAll(line => line.Name == "PostMonstrosity");
            }
            if (item.type == ModContent.ItemType<MutantsCurse>())
            {
                tooltips.RemoveAll(line => line.Name == "PostND");
            }
        }


        public override bool CanUseItem(Item item, Player player)
        {
            if (item.type == ModContent.ItemType<MutantsCurse>())
            {
                return true;
            }
            return base.CanUseItem(item, player);
        }
    }
}
