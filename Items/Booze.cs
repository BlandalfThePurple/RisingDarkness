using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace RisingDarkness.Items
{
    
    public class Booze : ModItem
    {
        
        public override void SetDefaults()
        {
            item.name = "Booze";
            item.width = 32;
            item.height = 32;
            item.rare = 6;
            item.maxStack = 999;
            item.toolTip = "Woohoo, generic alcohol!";
            item.value = Item.buyPrice(0,0,0,50);
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "MartiniGlass", 1);
            recipe.AddIngredient(ItemID.Blinkroot, 1);
            recipe.AddTile(null, "Bar");
            recipe.SetResult(this, 1);
            recipe.AddRecipe();
        }
    }
    
}