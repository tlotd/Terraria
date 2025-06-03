using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;

namespace tlotd.Content.Armor
{ 
	[AutoloadEquip(EquipType.Head)]
	public class BethanysMask : ModItem
	{
		public override void SetDefaults()
		{
			Item.value = Item.sellPrice(gold:1);
			Item.rare = ItemRarityID.Cyan;
			Item.vanity = true;
		}

		public override void UpdateEquip(Player player)
		{
			player.GetDamage(DamageClass.Melee) += 0.05f;
		}

		public override void UpdateArmorSet(Player player)
		{
			player.setBonus = Language.GetTextValue("Mods.tlotd.Items.Bethany.SetBonus");
			player.GetDamage(DamageClass.Melee) += 0.1f;
		}

		public override bool IsArmorSet(Item head, Item body, Item legs)
		{
			if (body.type == ModContent.ItemType<BethanysMechChestplate>() && legs.type == ModContent.ItemType<BethanysMechPants>())
			{
				return true;
			}
			return false;
		}
	}
}
