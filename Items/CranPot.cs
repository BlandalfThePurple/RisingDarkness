using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using RisingDarkness;

namespace RisingDarkness.Items
{
    
    public class CranPot : ModItem
    {
        public DarkPlayer pl;
        public override void SetDefaults()
        {
            item.name = "Cranberry Potion";
            item.width = 34;
            item.height = 34;
            item.rare = 10;
            item.maxStack = 40;
            item.toolTip2 = "Mmm, cranberries!";
            item.toolTip = "Must be used manually";
            item.value = Item.buyPrice(0,1,0,0);
            item.consumable = true;
            item.useSound = mod.GetSoundSlot(SoundType.Item, "Sounds/Item/MmmCranberries");
            item.healLife = 400;
            item.useAnimation = 30;
			item.useTime = 30;
			item.useStyle = 2;
            item.potion = true;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "CranJuice", 1);
            recipe.AddIngredient(ItemID.Bottle, 4);
            recipe.AddTile(TileID.Bottles);
            recipe.SetResult(this, 4);
            recipe.AddRecipe();
        }
        public override bool CanUseItem(Player player)
		{
            pl = ((DarkPlayer)player.GetModPlayer(mod, "DarkPlayer"));
			if(pl.sick){
                item.useSound = 0;
                //item.healLife = 0;  
                return false;  
            }else{
                item.useSound = mod.GetSoundSlot(SoundType.Item, "Sounds/Item/MmmCranberries");
                item.healLife = 400;
			    return true;
            }
		}
        public override bool UseItem(Player player)
		{
            pl = ((DarkPlayer)player.GetModPlayer(mod, "DarkPlayer"));
            if(!pl.sick){
			player.AddBuff(21, 3600, true);
            pl.pSick = 3600;
            }
			return true;
            
		}
        
    }
    
}