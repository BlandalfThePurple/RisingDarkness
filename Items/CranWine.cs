using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace RisingDarkness.Items
{
    
    public class CranWine : ModItem
    {
        
        public override void SetDefaults()
        {
            item.name = "Cranberry Wine";
            item.width = 32;
            item.height = 32;
            item.rare = 10;
            item.maxStack = 999;
            item.toolTip = "Aww, hell yeah!";
            item.toolTip2 = "Totally [not] worth it.";
            item.value = Item.buyPrice(0,1,0,0);
            item.useSound = mod.GetSoundSlot(SoundType.Item, "Sounds/Item/MmmCranberries");
            item.useAnimation = 30;
			item.useTime = 30;
			item.useStyle = 2;
            item.autoReuse = true;
            item.useTurn = true;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "Booze", 1);
            recipe.AddIngredient(null, "CranJuice", 1);
            recipe.AddTile(null, "Bar");
            recipe.SetResult(this, 1);
            recipe.AddRecipe();
        }
    }
    
}