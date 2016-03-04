using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace RisingDarkness.Items
{
    
    public class CranBar : ModItem
    {
        
        public override void SetDefaults()
        {
            item.name = "Cranberrium Bar";
            item.width = 32;
            item.height = 32;
            item.rare = 10;
            item.maxStack = 999;
            item.toolTip = "Whaddaya mean, not possible!?";
            item.value = Item.buyPrice(0,25,0,0);
            item.createTile = mod.TileType("CranBarPlaced");
            item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 10;
			item.useStyle = 1;
			item.consumable = true;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "Cranberry", 1);
            recipe.AddIngredient(ItemID.LunarBar, 2);
            recipe.AddTile(null, "CrimsonForge");
            recipe.SetResult(this, 1);
            recipe.AddRecipe();
        }
    }
}