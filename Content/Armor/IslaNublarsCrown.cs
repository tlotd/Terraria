using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;

namespace tlotd.Content.Armor
{ 
	[AutoloadEquip(EquipType.Head)]
	public class IslaNublarsCrown : ModItem
	{
		public override void SetDefaults()
		{
			Item.value = Item.sellPrice(gold:1);
			Item.rare = ItemRarityID.Cyan;
			Item.vanity = true;
		}

		public override void UpdateArmorSet(Player player)
		{
			player.setBonus = Language.GetTextValue("Mods.tlotd.Items.IslaNublar.SetBonus");
			player.GetDamage<Content.DamageClasses.Legendary>() += 0.2f;
		}

		public override bool IsArmorSet(Item head, Item body, Item legs)
		{
			if (body.type == ModContent.ItemType<IslaNublarsChestplate>() && legs.type == ModContent.ItemType<IslaNublarsLeggings>())
			{
				return true;
			}
			return false;
		}
	}
}
