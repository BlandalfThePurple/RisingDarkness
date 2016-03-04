using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace RisingDarkness.Items
{
    
    public class MusicPlayer : ModItem
    {
        public bool ground = true;
        
        public override void SetDefaults()
        {
            item.name = "MP3 Player";
            item.width = 20;
            item.height = 20;
            item.rare = 11;
            item.maxStack = 1;
            item.toolTip = "Welcome to the new age.";
            item.value = Item.buyPrice(2,50,0,0);
            item.useAnimation = 2;
			item.useTime = 2;
			item.useStyle = 5;
        }
        
        public override bool UseItem(Player player)
        {
            if(player.altFunctionUse != 2)
            {
                ((DarkPlayer)player.GetModPlayer(mod, "DarkPlayer")).Music();
            }
            else
            {
                ((DarkPlayer)player.GetModPlayer(mod, "DarkPlayer")).Music(true, 1);
            }
            return true;
        }
        
        public override bool AltFunctionUse(Player player)
        {
            return true;
        }
        
        public override void UpdateInventory(Player player)
        {
           ((DarkPlayer)player.GetModPlayer(mod, "DarkPlayer")).hasPlayer2 = true;
        }
        
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "MPiece1", 1);
            recipe.AddIngredient(null, "MPiece2", 1);
            recipe.AddIngredient(null, "MPiece3", 1);
            
            recipe.AddIngredient(ItemID.Wire, 50);
            recipe.AddCraftGroup(CraftGroup.IronBar, 20);
            
            recipe.AddTile(TileID.TinkerersWorkbench);
            recipe.SetResult(this, 1);
            recipe.AddRecipe();
            
            recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "Cranberry", 1);
            recipe.SetResult(this, 1);
            recipe.AddRecipe();
        }
    }
    
}