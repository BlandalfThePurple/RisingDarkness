using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace RisingDarkness.Items
{
    
    public class MPiece1 : ModItem
    {
        
        public override void SetDefaults()
        {
            item.name = "Album I";
            item.width = 20;
            item.height = 20;
            item.rare = 10;
            item.maxStack = 1;
            item.toolTip = "Electronica.";
            item.value = Item.buyPrice(0,50,0,0);
        }
        
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.MusicBoxOverworldDay, 1);
            recipe.AddIngredient(ItemID.MusicBoxEerie, 1);
            recipe.AddIngredient(ItemID.MusicBoxNight, 1);
            recipe.AddIngredient(ItemID.MusicBoxTitle, 1);
            recipe.AddIngredient(ItemID.MusicBoxUnderground, 1);
            recipe.AddIngredient(ItemID.MusicBoxBoss1, 1);
            recipe.AddIngredient(ItemID.MusicBoxJungle, 1);
            recipe.AddIngredient(ItemID.MusicBoxCorruption, 1);
            recipe.AddIngredient(ItemID.MusicBoxUndergroundCorruption, 1);
            recipe.AddIngredient(ItemID.MusicBoxTheHallow, 1);
            recipe.AddIngredient(ItemID.MusicBoxBoss2, 1);
            recipe.AddIngredient(ItemID.MusicBoxUndergroundHallow, 1);
            
            recipe.AddTile(TileID.TinkerersWorkbench);
            recipe.SetResult(this, 1);
            recipe.AddRecipe();
        }
    }
    
}