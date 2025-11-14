using Terraria.ModLoader;
using System;
using System.Reflection;
using MonoMod.RuntimeDetour;
using Terraria;
using FargowiltasSouls.Content.Items.Summons;
using CSENamelessAfterMutant.Common;

namespace CSENamelessAfterMutant
{
    public class CSENamelessAfterMutant : Mod
    {
        public override void Load()
        {
            ChecklistFixer.Checklist.Update();
        }
    }
}
