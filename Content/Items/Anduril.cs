using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace tlotd.Content.Items
{ 
	public class Anduril : ModItem
	{
		public override void SetDefaults()
		{
			Item.damage = 180;
			Item.DamageType = Content.DamageClasses.Legendary.Instance;
			Item.width = 72;
			Item.height = 72;
			Item.useTime = 16;
			Item.useAnimation = 16;
			Item.useStyle = ItemUseStyleID.Swing;
			Item.knockBack = 6;
			Item.value = Item.sellPrice(gold: 5, silver: 50);
			Item.rare = ItemRarityID.Yellow;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe()
				.AddIngredient<Content.Items.Placeables.EclipsedMithrilBar>(10)
				.AddIngredient(ItemID.BrokenHeroSword)
				.AddTile(TileID.MythrilAnvil)
				.Register();
		}

		public override void OnHitNPC(Player player, NPC target, NPC.HitInfo hit, int damageDone)
		{
			if (Main.rand.NextBool(3))
			target.AddBuff(BuffID.OnFire, 300);
		}
	}
}
