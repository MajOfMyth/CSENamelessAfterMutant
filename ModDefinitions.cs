using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ModLoader;

namespace CSENamelessAfterMutant
{
    public static class ModDefinitions
    {
        public static FargowiltasSouls.FargowiltasSouls Fargo => ModLoader.GetMod("FargowiltasSouls") as FargowiltasSouls.FargowiltasSouls;
    }
}
