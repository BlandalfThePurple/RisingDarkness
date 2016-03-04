using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace RisingDarkness.Items
{
    
    public class DrinkingMartini : ModItem
    {
        
        public override void SetDefaults()
        {
            item.name = "Martini";
            item.width = 32;
            item.height = 32;
            item.rare = 9;
            item.maxStack = 999;
            item.toolTip = "So stylish!";
            item.value = Item.buyPrice(0,0,5,0);
            item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 30;
			item.useTime = 30;
			item.useStyle = 2;
			item.consumable = true;
        }
        public override bool UseItem(Player player){
            
            player.AddBuff(mod.BuffType("Drunk"), 36000);
            DarkPlayer pl = ((DarkPlayer)player.GetModPlayer(mod, "DarkPlayer"));
            pl.drunkAtk += 5;
            pl.drunkDef -= 1;
            pl.drunkKB -= 3;
            return true;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "Booze", 10);
            recipe.AddIngredient(ItemID.Moonglow, 3);
            recipe.AddIngredient(ItemID.Umbrella, 1);
            recipe.AddTile(null, "Bar");
            recipe.SetResult(this, 10);
            recipe.AddRecipe();
        }
    }
}