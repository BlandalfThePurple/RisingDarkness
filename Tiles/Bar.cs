using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace RisingDarkness.Tiles
{
	public class Bar : ModTile
	{
		public override void SetDefaults()
		{
            Main.tileSolidTop[Type] = true;
			Main.tileFrameImportant[Type] = true;
			Main.tileNoAttach[Type] = true;
			Main.tileLavaDeath[Type] = true;
			TileObjectData.newTile.CopyFrom(TileObjectData.Style2x2);
			TileObjectData.newTile.CoordinateHeights = new int[]{16, 16};
			TileObjectData.addTile(Type);
			disableSmartCursor = true;
			adjTiles = new int[]{TileID.Bottles};
		}

		public override void KillMultiTile(int i, int j, int frameX, int frameY)
		{
			Item.NewItem(i * 16, j * 16, 48, 32, mod.ItemType("BarItem"));
		}
	}

}