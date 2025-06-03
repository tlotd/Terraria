using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;

namespace tlotd.Content.Buffs
{ 
	public class Refreshed : ModBuff
	{
		public override void SetStaticDefaults()
		{
			Main.debuff[Type] = false;
            Main.pvpBuff[Type] = true;
            Main.buffNoSave[Type] = true;
			Main.buffNoTimeDisplay[Type] = false;
			BuffID.Sets.NurseCannotRemoveDebuff[Type] = true;
		}

		public override void Update(Player player, ref int buffIndex)
		{
			player.lifeRegen += 10;
			player.moveSpeed += 0.5f;
		}
	}
}
