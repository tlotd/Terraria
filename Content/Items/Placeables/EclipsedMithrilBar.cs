using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;

namespace tlotd.Content.Items.Placeables
{ 
	public class EclipsedMithrilBar : ModItem
	{
		public override void SetStaticDefaults()
		{
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 25;
			ItemID.Sets.SortingPriorityMaterials[Type] = 59;
		}

		public override void SetDefaults()
		{
			Item.width = 30;
			Item.height = 24;
			Item.maxStack = 9999;
			Item.consumable = true;
			Item.value = Item.sellPrice(copper:50);
			Item.rare = ItemRarityID.Yellow;

			Item.useStyle = ItemUseStyleID.Swing;
			Item.useAnimation = 15;
			Item.useTime = 10;
			Item.useTurn = true;
			Item.autoReuse = true;

			Item.createTile = ModContent.TileType<Tiles.EclipsedMithrilBars>();
			Item.placeStyle = 0;
		}

		public override void AddRecipes()
        {
            CreateRecipe()
				.AddIngredient<Content.Items.Placeables.EclipsedMithrilOre>(5)
				.AddTile(TileID.MythrilAnvil)
				.Register();
		}
	}
}
