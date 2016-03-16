using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.DataStructures;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace RisingDarkness.Items
{
    
    public class HallowedGlove : ModItem
    {
        public int pressLong = -1;
        public bool afu = false;
        public bool already = false;
        
        public override void SetDefaults()
        {
            item.name = "Hallowed Gauntlet";
            item.width = 10;
            item.height = 10;
            item.rare = 11;
            item.maxStack = 1;
            item.toolTip = "Okay, this is just arcane.";
            item.value = Item.buyPrice(6,0,0,0);
            item.useAnimation = 2;
			item.useTime = 20;
			item.useStyle = 1;
            item.accessory = true;
        }
        
        public override bool UseItem(Player player)
        {
            
            DarkPlayer pl = ((DarkPlayer)player.GetModPlayer(mod, "DarkPlayer"));
            
            if(player.altFunctionUse != 2 && !afu)
            {
               pl.discord = item;
            }
            else
            {
                pl.magicMirror = item;
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
           
           if(pl.pressLong == pressLong)
           {
               //Main.NewText("Flag1");
               if(!already)
               {

                    afu = false;
                    player.altFunctionUse = 0;
                    UseItem(player);
               }
                pl.mirrorUsed = false;
                pl.pressLong = 0;
                    already = false;
           }
           
           if(pl.pressLong > 15 && !pl.mirrorUsed)
            {
                afu = true;
                pl.pressLong = 0;
                UseItem(player);
                already = true;
            }
           pressLong = pl.pressLong != 0 ? pl.pressLong : -1;
           
           if(pl.dcd > 0)
           {
               pl.dcd--;
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
		player.accDreamCatcher = true;
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
            recipe.AddIngredient(ItemID.RodofDiscord, 1);
            recipe.AddIngredient(null, "SmartGlove", 1);
            recipe.AddTile(TileID.TinkerersWorkbench);
            recipe.SetResult(this, 1);
            recipe.AddRecipe();
        }
    }
    
}