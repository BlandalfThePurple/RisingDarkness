using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using RisingDarkness;
using Microsoft.Xna.Framework;

namespace RisingDarkness.Items
{
    class Goblet : ModItem
    {
        public override void SetDefaults()
        {
            item.name = "Goblet of Mithras";
            item.width = 32;
            item.height = 32;
            item.rare = -11;
            item.maxStack = 999;
            item.toolTip2 = "The hunt for the Hallowed Cup is all the rage nowadays!";
            item.toolTip = "Exchanges mana for life";
            item.value = Item.buyPrice(5, 0, 0, 0);
            item.useAnimation = 2;
            item.useTime = 2;
            item.useStyle = 2;
            item.autoReuse = true;
            item.useTurn = true;
            item.healLife = 1;
            item.mana = 5;
        }

        public override bool UseItem(Player player)
        {
            if(player.statLife == player.statLifeMax2)
            {
                item.mana = 0;
                item.healLife = 0;
            }
            else
            {
                SetDefaults();
            }

            return true;

        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.DirtBlock);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
 
    }
}
