using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.DataStructures;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace RisingDarkness.Items
{
    
    public class Smartphone : ModItem
    {
        public bool ground = true;
        
        public override void SetDefaults()
        {
            item.name = "Smartphone";
            item.width = 20;
            item.height = 20;
            item.rare = 11;
            item.maxStack = 1;
            item.toolTip = "The new iCan't break copyright";
            item.value = Item.buyPrice(5,0,0,0);
            item.useAnimation = 120;
			item.useTime = 120;
			item.useStyle = 5;
        }
        
        public override bool UseItem(Player player)
        {
            
            DarkPlayer pl = ((DarkPlayer)player.GetModPlayer(mod, "DarkPlayer"));
            
            if(player.altFunctionUse != 2)
            {
               pl.magicMirror = item;
            }
            else
            {
                pl.Music(true, 1);
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
        if(player.accCompass < 1)
        {
        player.accCompass = 1;
        }
        if(player.accWatch < 1)
        {
		player.accWatch = 1;
        }
        if(player.accDepthMeter < 1)
        {
		player.accDepthMeter = 1;
        }
		player.accFishFinder = true;
		player.accWeatherRadio = true;
		player.accJarOfSouls = true;
		player.accCalendar = true;
		player.accThirdEye = true;
		player.accStopwatch = true;
		player.accOreFinder = true;
		player.accCritterGuide = true;
		player.accDreamCatcher = true;;
        }
        
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.CellPhone, 1);
            recipe.AddIngredient(null, "MusicPlayer", 1);
            
            recipe.AddTile(TileID.TinkerersWorkbench);
            recipe.SetResult(this, 1);
            recipe.AddRecipe();
        }
    }
    
}