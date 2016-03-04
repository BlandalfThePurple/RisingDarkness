using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;
using Terraria.DataStructures;

namespace RisingDarkness.Tiles
{
	public class CrimsonForge : ModTile
	{
		public override void SetDefaults()
		{
			Main.tileFrameImportant[Type] = true;
			Main.tileNoAttach[Type] = true;
			Main.tileLavaDeath[Type] = true;
			TileObjectData.newTile.CopyFrom(TileObjectData.Style3x2);
			//TileObjectData.newTile.CoordinateHeights = new int[]{16, 16};
			TileObjectData.addTile(Type);
			AddMapEntry(new Color(255,0,0), "Crimson Forge");
			disableSmartCursor = true;
			adjTiles = new int[]{TileID.Hellforge,TileID.AdamantiteForge,TileID.Furnaces};
		    animationFrameHeight = 34;
        }

		public override void KillMultiTile(int i, int j, int frameX, int frameY)
		{
			Item.NewItem(i * 16, j * 16, 48, 32, mod.ItemType("ForgeItem"));
		}
       /* public virtual void AnimateTile()
		{
			if (++Main.tileFrameCounter[Type] >= 16)
			{
				Main.tileFrameCounter[Type] = 0;
				if (++Main.tileFrame[Type] >= 3)
				{
					Main.tileFrame[Type] = 0;
				}
              
			}
            
   
		} */
        
        public override void PostDraw(int i, int j, SpriteBatch spritebatch){
            //Main.tile[i,j].frameY = (short)Main.tileFrame[type] * 34);
            
        }
        
	}

}