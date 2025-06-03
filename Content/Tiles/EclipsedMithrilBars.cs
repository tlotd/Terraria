using Terraria;
using Terraria.ModLoader;
using Terraria.DataStructures;
using Terraria.ObjectData;
using Terraria.Localization;
using Microsoft.Xna.Framework;

namespace tlotd.Content.Tiles
{ 
	public class EclipsedMithrilBars : ModTile
	{
		public override void SetStaticDefaults()
		{
			Main.tileSolid[Type] = true;
			Main.tileSolidTop[Type] = true;
			Main.tileShine[Type] = 1100;
			Main.tileFrameImportant[Type] = true;

			TileObjectData.newTile.CopyFrom(TileObjectData.Style1x1);
			TileObjectData.newTile.StyleHorizontal = true;
			TileObjectData.newTile.LavaDeath = false;
			TileObjectData.addTile(Type);

			AddMapEntry(new Color(63, 38, 18), Language.GetText("MapObject.MetalBar"));

			MineResist = 1.5f;
			MinPick = 200;
		}
	}
}
