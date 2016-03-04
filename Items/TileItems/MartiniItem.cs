using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace RisingDarkness.Items
{
    
    public class MartiniItem : ModItem
    {
        
        public override void SetDefaults()
        {
            item.name = "Decorative Martini";
            item.width = 32;
            item.height = 32;
            item.rare = 9;
            item.maxStack = 999;
            item.toolTip = "You know you want one.";
            item.value = Item.buyPrice(0,0,5,0);
            item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 10;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("Martini");
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "DrinkingMartini", 1);
            recipe.AddTile(null, "Bar");
            recipe.SetResult(this, 1);
            recipe.AddRecipe();
        }
    }
}