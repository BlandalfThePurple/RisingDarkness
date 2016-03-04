using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace RisingDarkness.Items
{
    
    public class AnvilItem : ModItem
    {
        
        public override void SetDefaults()
        {
            item.name = "Red Anvil";
            item.width = 32;
            item.height = 32;
            item.rare = 9;
            item.maxStack = 999;
            item.toolTip = "Hammer like Hephaestus!";
            item.value = Item.buyPrice(0,25,0,0);
            item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 10;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("RedAnvil");
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "CranBar", 5);
            recipe.AddTile(null, "CrimsonForge");
            recipe.SetResult(this, 1);
            recipe.AddRecipe();
        }
    }
}