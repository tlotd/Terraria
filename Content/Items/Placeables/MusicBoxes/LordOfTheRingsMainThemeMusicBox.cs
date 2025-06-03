using Terraria.ModLoader;
using Terraria.ID;

namespace tlotd.Content.Items.Placeables.MusicBoxes
{
    [LegacyName("LordOfTheRingsMusicbox")]
    public class LordOfTheRingsMainThemeMusicBox : MusicBox, ILocalizedModType
    {
        public override int MusicBoxTile => ModContent.TileType<Tiles.MusicBoxes.LordOfTheRingsMainThemeMusicBox>();
        public new string LocalizationCategory => "Items.Placeables.MusicBoxes";
    }
}
