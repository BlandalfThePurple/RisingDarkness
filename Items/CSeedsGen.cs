using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace RisingDarkness.Items
{
    
    public class CSeedsGen : GlobalItem
    {
        
        public override void OpenVanillaBag(string context, Player player, int arg)
		{
			if (context == "bossBag" && arg == ItemID.MoonLordBossBag)
			{
				player.QuickSpawnItem(mod.ItemType("CranSeeds"), 1);
			}
            
		}
        
    }
    
}