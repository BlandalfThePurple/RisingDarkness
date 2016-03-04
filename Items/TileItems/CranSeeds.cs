using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace RisingDarkness.Items
{
    
    public class CranSeeds : ModItem
    {
        
        public override void SetDefaults()
        {
            item.name = "C";
            item.width = 32;
            item.height = 32;
            item.rare = 8;
            item.maxStack = 999;
            item.toolTip = "What could these possibly grow?";
            item.value = Item.buyPrice(0,1,0,0);
            item.createTile = mod.TileType("CranPlant");
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
            recipe.AddTile(null, "Juicer");
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
        
    }
    
}