using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace RisingDarkness.Items
{
    
    public class BarItem : ModItem
    {
        
        public override void SetDefaults()
        {
            item.name = "Bar";
            item.width = 32;
            item.height = 32;
            item.rare = 9;
            item.maxStack = 999;
            item.toolTip = "OOOOHHH YEEEAH!";
            item.value = Item.buyPrice(0,0,1,0);
            item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 10;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("Bar");
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.StoneBlock, 20);
            recipe.AddCraftGroup(CraftGroup.Wood, 5);
            recipe.AddTile(null, "RedAnvil");
            recipe.SetResult(this, 1);
            recipe.AddRecipe();
        }
    }
}