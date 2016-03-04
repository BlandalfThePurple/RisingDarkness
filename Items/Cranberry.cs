using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace RisingDarkness.Items
{
    
    public class Cranberry : ModItem
    {
        
        public override void SetDefaults()
        {
            item.name = "Cranberry";
            item.width = 32;
            item.height = 32;
            item.rare = 10;
            item.maxStack = 999;
            item.toolTip = "FOR CRANBERRY!!!";
            item.value = Item.buyPrice(0,10,0,0);
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.DirtBlock, 1);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this, 999);
            recipe.AddRecipe();
        }
    }
    
}