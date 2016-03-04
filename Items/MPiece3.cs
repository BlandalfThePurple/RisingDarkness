using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace RisingDarkness.Items
{
    
    public class MPiece3 : ModItem
    {
        
        public override void SetDefaults()
        {
            item.name = "Album III";
            item.width = 20;
            item.height = 20;
            item.rare = 10;
            item.maxStack = 1;
            item.toolTip = "A wild ride.";
            item.value = Item.buyPrice(0,50,0,0);
        }
        
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.MusicBoxBoss5, 1);
            recipe.AddIngredient(ItemID.MusicBoxTemple, 1);
            recipe.AddIngredient(ItemID.MusicBoxEclipse, 1);
            recipe.AddIngredient(ItemID.MusicBoxMushrooms, 1);
            recipe.AddIngredient(ItemID.MusicBoxPumpkinMoon, 1);
            recipe.AddIngredient(ItemID.MusicBoxAltUnderground , 1);
            recipe.AddIngredient(ItemID.MusicBoxFrostMoon, 1);
            recipe.AddIngredient(ItemID.MusicBoxUndergroundCrimson, 1);
            recipe.AddIngredient(ItemID.MusicBoxLunarBoss, 1);
            recipe.AddIngredient(ItemID.MusicBoxMartians, 1);
            recipe.AddIngredient(ItemID.MusicBoxPirates, 1);
            recipe.AddIngredient(ItemID.MusicBoxHell, 1);
            recipe.AddIngredient(ItemID.MusicBoxTowers, 1);
            recipe.AddIngredient(ItemID.MusicBoxGoblins, 1);
            
            recipe.AddTile(TileID.TinkerersWorkbench);
            recipe.SetResult(this, 1);
            recipe.AddRecipe();
        }
    }
    
}