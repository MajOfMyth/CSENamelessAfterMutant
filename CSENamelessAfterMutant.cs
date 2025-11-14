using Terraria.ModLoader;

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
