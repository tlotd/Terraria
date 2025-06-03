using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace tlotd.Content.Armor
{ 
	[AutoloadEquip(EquipType.Legs)]
	public class Nischi2612sTuxedoPants : ModItem
	{
		public override void SetDefaults()
		{
			Item.value = Item.sellPrice(gold:1);
			Item.rare = ItemRarityID.Cyan;
			Item.vanity = true;
		}
	}
}
