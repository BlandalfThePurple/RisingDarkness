using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;
using Terraria.Enums;
using RisingDarkness;

namespace RisingDarkness.Tiles
{
	public class CranPlant : ModTile
	{
		public override void SetDefaults()
		{
			Main.tileFrameImportant[Type] = true;
			Main.tileNoFail[Type] = true;
            Main.tileNoAttach[Type] = true;
			Main.tileLavaDeath[Type] = true;
			TileObjectData.newTile.CopyFrom(TileObjectData.StyleAlch);
			TileObjectData.newTile.AnchorValidTiles = new int[]
			{
				TileID.Grass
			};
			TileObjectData.newTile.AnchorAlternateTiles = new int[]
			{
				78, 
				TileID.PlanterBox
			};
			TileObjectData.addTile(Type);
			AddMapEntry(new Color(255,0,0), "C...");
		}

		public override void SetSpriteEffects(int i, int j, ref SpriteEffects spriteEffects)
		{
			if (i % 2 == 1)
			{
				spriteEffects = SpriteEffects.FlipHorizontally;
			}
		}

		public override bool Drop(int i, int j)
		{
			int stage = Main.tile[i, j].frameX / 18;
			if (stage == 2)
			{
				
				//TODO Cranboss ;D
                Item.NewItem(i * 16, j * 16, 48, 32, mod.ItemType("CranSeeds"));
                if(Main.rand.Next(10)==0)
                {
                    
                    Item.NewItem(i * 16, j * 16, 48, 32, mod.ItemType("CranSeeds"));
                    
                }
                
			}
			return false;
		}

		public override void RandomUpdate(int i, int j)
		{
			if (Main.tile[i, j].frameX == 0)
			{
				Main.tile[i, j].frameX += 18;
			}
			else if (Main.tile[i, j].frameX == 18)
			{
				Main.tile[i, j].frameX += 18;
			}
		}
        
	}
    
}
