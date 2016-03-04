using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace RisingDarkness.Items
{
    
    public class MartiniGlass : ModItem
    {
        
        public override void SetDefaults()
        {
            item.name = "Cocktail Glass";
            item.width = 32;
            item.height = 32;
            item.rare = 2;
            item.maxStack = 999;
            item.toolTip = "Make some alcohol!";
            item.value = Item.buyPrice(0,0,0,50);
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Glass);
            recipe.AddTile(TileID.Furnaces);
            recipe.SetResult(this, 1);
            recipe.AddRecipe();
        }
    }
    
}