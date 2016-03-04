using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace RisingDarkness.Items
{
    
    public class MPiece2 : ModItem
    {
        
        public override void SetDefaults()
        {
            item.name = "Album II";
            item.width = 20;
            item.height = 20;
            item.rare = 10;
            item.maxStack = 1;
            item.toolTip = "The golden oldies";
            item.value = Item.buyPrice(0,50,0,0);
        }
        
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.MusicBoxBoss3, 1);
            recipe.AddIngredient(ItemID.MusicBoxSnow, 1);
            recipe.AddIngredient(ItemID.MusicBoxSpace, 1);
            recipe.AddIngredient(ItemID.MusicBoxCrimson, 1);
            recipe.AddIngredient(ItemID.MusicBoxBoss4, 1);
            recipe.AddIngredient(ItemID.MusicBoxAltOverworldDay, 1);
            recipe.AddIngredient(ItemID.MusicBoxRain, 1);
            recipe.AddIngredient(ItemID.MusicBoxIce, 1);
            recipe.AddIngredient(ItemID.MusicBoxDesert, 1);
            recipe.AddIngredient(ItemID.MusicBoxOcean, 1);
            recipe.AddIngredient(ItemID.MusicBoxDungeon, 1);
            recipe.AddIngredient(ItemID.MusicBoxPlantera, 1);
            
            recipe.AddTile(TileID.TinkerersWorkbench);
            recipe.SetResult(this, 1);
            recipe.AddRecipe();
        }
    }
    
}