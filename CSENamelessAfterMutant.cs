using Terraria.ModLoader;
using System.Collections.Generic;
using FargowiltasSouls.Content.Bosses.MutantBoss;
using System.Collections;
using System.Reflection;
using System;

namespace CSENamelessAfterMutant
{
    public class CSENamelessAfterMutant : Mod
    {

        internal static List<(int, float)> changes = new List<(int, float)>
        {
            (ModContent.NPCType<MutantBoss>(), 27f),
        };

        public override void PostSetupContent()
        {
            ChangeBossProgressions(changes.ToArray());
        }

        //i cant get it to work anymore im stealing this
        public static void ChangeBossProgressions(params (int npcID, float newProgression)[] changes)
        {
            if (ModLoader.TryGetMod("BossChecklist", out Mod bossChecklist))
            {
                // get access to bossTracker
                object bossTracker = bossChecklist.GetType()
                    .GetField("bossTracker", BindingFlags.NonPublic | BindingFlags.Static)
                    .GetValue(null);

                // get entries list
                FieldInfo sortedEntriesField = bossTracker.GetType()
                    .GetField("SortedEntries", BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance);
                IList entries = (IList)sortedEntriesField.GetValue(bossTracker);

                // prepare for reflection
                FieldInfo npcIDsField = null;
                FieldInfo progressionField = null;
                var entriesToChange = new List<(object entry, float newProg)>();

                // find all entries
                foreach (object entry in entries)
                {
                    if (npcIDsField == null)
                    {
                        npcIDsField = entry.GetType().GetField("npcIDs",
                            BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);

                        progressionField = entry.GetType().GetField("progression",
                            BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);

                        if (npcIDsField == null || progressionField == null)
                            throw new InvalidOperationException("Required fields was not found.");
                    }

                    List<int> currentNPCIDs = (List<int>)npcIDsField.GetValue(entry);
                    foreach (var change in changes)
                    {
                        if (currentNPCIDs.Contains(change.npcID))
                        {
                            entriesToChange.Add((entry, change.newProgression));
                            break;
                        }
                    }
                }

                // apply edits
                foreach (var change in entriesToChange)
                {
                    progressionField.SetValue(change.entry, change.newProg);
                }

                // re-sort
                List<object> sortedList = new List<object>();
                foreach (object entry in entries)
                    sortedList.Add(entry);

                sortedList.Sort((x, y) =>
                {
                    float xProg = (float)progressionField.GetValue(x);
                    float yProg = (float)progressionField.GetValue(y);
                    return xProg.CompareTo(yProg);
                });

                // update original list
                entries.Clear();
                foreach (object entry in sortedList)
                    entries.Add(entry);
            }
        }
    }
}