using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace RisingDarkness.Items
{
    
    public class ForgeItem : ModItem
    {
        
        public override void SetDefaults()
        {
            item.name = "Crimson Forge";
            item.width = 32;
            item.height = 32;
            item.rare = 9;
            item.maxStack = 999;
            item.toolTip = "Make the best alloys.";
            item.value = Item.buyPrice(0,25,0,0);
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 10;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("CrimsonForge");
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "Cranberry", 10);
            recipe.AddIngredient(ItemID.AdamantiteForge, 1);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this, 1);
            recipe.AddRecipe();
            recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "Cranberry", 10);
            recipe.AddIngredient(ItemID.TitaniumForge, 1);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this, 1);
            recipe.AddRecipe();
        }
    }
}