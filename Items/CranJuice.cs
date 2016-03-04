using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace RisingDarkness.Items
{
    
    public class CranJuice : ModItem
    {
        
        public override void SetDefaults()
        {
            item.name = "Cranberry Juice";
            item.width = 18;
            item.height = 18;
            item.rare = 10;
            item.maxStack = 999;
            item.toolTip = "Blood of the cranberry.";
            item.value = Item.buyPrice(0,8,0,0);
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "Cranberry", 1);
            recipe.AddIngredient(ItemID.Mug, 1);
            recipe.AddTile(null, "Juicer");
            recipe.SetResult(this, 1);
            recipe.AddRecipe();
        }
    }
    
}