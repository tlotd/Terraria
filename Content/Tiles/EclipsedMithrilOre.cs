using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace tlotd.Content.Tiles
{ 
	public class EclipsedMithrilOre : ModTile
	{
		public override void SetStaticDefaults()
		{
			TileID.Sets.Ore[Type] = true;
			Main.tileSpelunker[Type] = true;
			Main.tileOreFinderPriority[Type] = 725;
			Main.tileShine[Type] = 900;
			Main.tileShine2[Type] = true;
			Main.tileMergeDirt[Type] = true;
			Main.tileSolid[Type] = true;
			Main.tileBlockLight[Type] = true;

			AddMapEntry(new Color(63, 38, 18), CreateMapEntryName());

			DustType = DustID.Tungsten;
			HitSound = SoundID.Tink;
			MineResist = 1.5f;
			MinPick = 200;
		}
	}
}
