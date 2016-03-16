using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using RisingDarkness;
using Microsoft.Xna.Framework;

namespace RisingDarkness.Items
{
    class PortaHole : ModItem
    {
        public override void SetDefaults()
        {
            item.name = "Portable Wormhole";
            item.width = 20;
            item.height = 20;
            item.rare = 9;
            item.maxStack = 1;
            item.toolTip = "Tiiiime and spaaace!";
            item.value = Item.buyPrice(0, 5, 0, 0);
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.WormholePotion, 120);
            recipe.SetResult(this);
            recipe.AddRecipe();
            recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "Cranberry", 1);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

        public override void UpdateInventory(Player player)
        {
            DarkPlayer pl = ((DarkPlayer)player.GetModPlayer(mod, "DarkPlayer"));
            pl.hasTruePlayer2 = true;
            pl.hasTruePlayer = true;
        }

    }
}
