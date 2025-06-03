using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace tlotd.Content.Items
{ 
	public class PaulanerSpezi : ModItem
	{
		public override void SetDefaults()
		{
			Item.width = 12;
			Item.height = 36;
			Item.maxStack = 9999;
			Item.useTime = 15;
			Item.useTurn = true;
			Item.useAnimation = 15;
			Item.consumable = true;
			Item.useStyle = ItemUseStyleID.EatFood;
			Item.value = Item.sellPrice(gold:1);
			Item.rare = ItemRarityID.Orange;
			Item.UseSound = SoundID.Item3;
			Item.buffType = ModContent.BuffType<Buffs.Refreshed>();
			Item.buffTime = 28000;
		}
	}
}
