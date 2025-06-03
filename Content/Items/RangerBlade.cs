using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace tlotd.Content.Items
{ 
	// This is a basic item template.
	// Please see tModLoader's ExampleMod for every other example:
	// https://github.com/tModLoader/tModLoader/tree/stable/ExampleMod
	public class RangerBlade : ModItem
	{
		// The Display Name and Tooltip of this item can be edited in the 'Localization/en-US_Mods.tlotd.hjson' file.
		public override void SetDefaults()
		{
			Item.damage = 89;
			Item.DamageType = Content.DamageClasses.Legendary.Instance;
			Item.width = 72;
			Item.height = 72;
			Item.useTime = 20;
			Item.useAnimation = 20;
			Item.useStyle = ItemUseStyleID.Swing;
			Item.knockBack = 6;
			Item.value = Item.buyPrice(gold: 5, silver: 52);
			Item.rare = ItemRarityID.Lime;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe()
				.AddIngredient(ItemID.ChlorophyteBar, 11)
				.AddTile(TileID.MythrilAnvil)
				.Register();
		}

		public override void OnHitNPC(Player player, NPC target, NPC.HitInfo hit, int damageDone)
		{
			if (Main.rand.NextBool(3))
			target.AddBuff(BuffID.CursedInferno, 300);
		}
	}
}
