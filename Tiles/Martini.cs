using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace RisingDarkness.Tiles
{
	public class Martini : ModTile
	{
		public override void SetDefaults()
		{
			Main.tileTable[Type] = true;
			Main.tileFrameImportant[Type] = true;
			Main.tileNoAttach[Type] = true;
			TileObjectData.newTile.CopyFrom(TileObjectData.Style1x2);
			TileObjectData.addTile(Type);
			disableSmartCursor = true;
            drop = mod.ItemType("MartiniItem");
            adjTiles = new int[]{TileID.Bottles,TileID.AlchemyTable};
		}

	}
    
}