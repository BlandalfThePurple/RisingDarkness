using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace RisingDarkness.Items
{
    
    public class Walker : ModItem
    {
        
        public override void SetDefaults()
        {
            item.name = "Walker of Doom";
            item.width = 32;
            item.height = 48;
            item.rare = 11;
            item.damage = 500;
            item.useStyle = 1;
            item.knockBack = 21;
            item.useTime = 60;
            item.useAnimation = 60;
            item.melee = true;
            item.maxStack = 1;
            item.toolTip = "Renowned by old people everywhere.";
            item.value = Item.buyPrice(2,0,0,0);
            item.autoReuse = true;
            item.useTurn = true;
            item.useSound = mod.GetSoundSlot(SoundType.Item, "Sounds/Item/ehhhhh");
        }
            public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.DirtBlock, 1);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this, 1);
            recipe.AddRecipe();
        }
    }
}