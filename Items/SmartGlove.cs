using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.DataStructures;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace RisingDarkness.Items
{
    
    public class SmartGlove : ModItem
    {
        public bool ground = true;
        
        public override void SetDefaults()
        {
            item.name = "Smart Glove";
            item.width = 20;
            item.height = 20;
            item.rare = 11;
            item.maxStack = 1;
            item.toolTip = "Those kids and their new-fangled gadgetry...";
            item.value = Item.buyPrice(5,50,0,0);
            item.useAnimation = 120;
			item.useTime = 120;
			item.useStyle = 2;
            item.accessory = true;
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
            DarkPlayer pl = ((DarkPlayer)player.GetModPlayer(mod, "DarkPlayer"));
            
           pl.hasPlayer2 = true;
           pl.hasAutoPlayer2 = true;
           
           if(pl.unpressTeleport3)
           {
               Main.NewText("Flag1");
               
               player.altFunctionUse = 0;
               pl.pressLong = 0;
               UseItem(player);
           }
           
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
        
        public override void UpdateEquip(Player player)
        {
            UpdateInventory(player);
            player.kbGlove = true;
            player.meleeSpeed += 0.1f;
            player.meleeDamage += 0.1f;
            player.magmaStone = true;
        }
        
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.FireGauntlet, 1);
            recipe.AddIngredient(null, "Smartphone", 1);
            recipe.AddTile(TileID.TinkerersWorkbench);
            recipe.SetResult(this, 1);
            recipe.AddRecipe();
        }
    }
    
}