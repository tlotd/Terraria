using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;

namespace tlotd.Content.Armor
{ 
	[AutoloadEquip(EquipType.Head)]
	public class Nischi2612sMask : ModItem
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
			player.setBonus = Language.GetTextValue("Mods.tlotd.Items.Nischi2612.SetBonus");
			player.GetDamage(DamageClass.Ranged) += 0.1f;
		}

		public override bool IsArmorSet(Item head, Item body, Item legs)
		{
			if (body.type == ModContent.ItemType<Nischi2612sTuxedo>() && legs.type == ModContent.ItemType<Nischi2612sTuxedoPants>())
			{
				return true;
			}
			return false;
		}
	}
}
