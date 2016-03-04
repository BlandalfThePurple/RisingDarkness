using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using RisingDarkness;

namespace RisingDarkness.Buffs
{
	public class Drunk : ModBuff
	{
		public override void SetDefaults()
		{
			Main.buffName[this.Type] = "Drunk";
			Main.buffTip[this.Type] = "You are under the influence!";
            Main.debuff[Type] = true;
		}

		public override void Update(Player player, ref int buffIndex)
		{
			((DarkPlayer)player.GetModPlayer(mod, "DarkPlayer")).drunk = true;
		}
	}
}
