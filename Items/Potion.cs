using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using RisingDarkness;

namespace RisingDarkness.Items
{
	public class Potion : GlobalItem
	{
        public DarkPlayer pl;
		public override bool UseItem(Item item, Player player)
		{
            pl = ((DarkPlayer)player.GetModPlayer(mod, "DarkPlayer"));
            if(item.healLife>0)
            {
                pl.pSick = 3600;
            }
            return true;
        }
    }
}