using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;

namespace tlotd.Content.Items.Placeables
{ 
	public class EclipsedMithrilOre : ModItem
	{
		public override void SetStaticDefaults()
		{
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 100;
			ItemID.Sets.SortingPriorityMaterials[Type] = 58;
		}

		public override void SetDefaults()
		{
			Item.width = 16;
			Item.height = 16;
			Item.maxStack = 9999;
			Item.consumable = true;
			Item.value = Item.sellPrice(copper:50);
			Item.rare = ItemRarityID.Yellow;

			Item.useStyle = ItemUseStyleID.Swing;
			Item.useAnimation = 15;
			Item.useTime = 10;
			Item.useTurn = true;
			Item.autoReuse = true;

			Item.createTile = ModContent.TileType<Tiles.EclipsedMithrilOre>();
		}
	}
}
