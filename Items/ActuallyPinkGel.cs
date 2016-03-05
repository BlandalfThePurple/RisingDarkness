using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.DataStructures;
using RisingDarkness;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace RisingDarkness.Items
{
	public class ActuallyPinkGel : GlobalItem
	{
        public DarkPlayer pl;
        public override void UpdateInventory(Item item, Player player)
		{
            if(item.type == 3111)
            {
                item.rare = 5;
            }
        }
		public override void Update(Item item, ref float gravity, ref float maxFallSpeed)
		{
            UpdateInventory(item,null);
        }
        public override bool PreDrawInInventory(Item item, SpriteBatch spriteBatch, Vector2 position, Rectangle frame, Color drawColor, Color itemColor, Vector2 origin, float scale)
        {
            UpdateInventory(item,null);
            return true;
        }
    }
}