using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace RisingDarkness.Items
{
    
    public class JuicerItem : ModItem
    {
        
        public override void SetDefaults()
        {
            item.name = "Juicer";
            item.width = 32;
            item.height = 32;
            item.rare = 9;
            item.maxStack = 999;
            item.toolTip = "Squeeze the life out of it!";
            item.value = Item.buyPrice(0,25,0,0);
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 10;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("Juicer");
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.LunarBar, 20);
            recipe.AddTile(null, "RedAnvil");
            recipe.SetResult(this, 1);
            recipe.AddRecipe();
            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.LunarBar, 1);
            recipe.SetResult(ItemID.LunarBar, 999);
            recipe.AddRecipe();
        }
    }
}