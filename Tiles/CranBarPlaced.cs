using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace RisingDarkness.Tiles
{
	public class CranBarPlaced : ModTile
	{
		public override void SetDefaults()
		{
			Main.tileSolidTop[Type] = true;
			Main.tileFrameImportant[Type] = true;
			Main.tileNoAttach[Type] = true;
			TileObjectData.newTile.CopyFrom(TileObjectData.Style1x1);
			TileObjectData.addTile(Type);
			AddMapEntry(new Color(255, 0, 0), "");
			disableSmartCursor = true;
            drop = mod.ItemType("CranBar");
		}

	}
    
}