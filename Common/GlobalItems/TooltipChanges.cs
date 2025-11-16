using FargowiltasSouls.Content.Items.Summons;
using NoxusBoss.Content.Items;
using Terraria.ModLoader;
using Terraria;
using System.Collections.Generic;

namespace CSENamelessAfterMutant.Common.GlobalItems
{
    public class TooltipChanges : GlobalItem
    {
        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            if (item.type == ModContent.ItemType<CheatPermissionSlip>())
            {
                //what?
                tooltips.RemoveAll(line => line.Name == "PosttMonstrosity");
            }
            if (item.type == ModContent.ItemType<MutantsCurse>())
            {
                tooltips.RemoveAll(line => line.Name == "PosttND");
            }
        }
    }
}
