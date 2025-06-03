using Terraria.ModLoader;
using Terraria.ID;

namespace tlotd.Content.Items.Placeables.MusicBoxes
{
    [LegacyName("TlotdMusicbox")]
    public class TlotdTitleMusicBox : MusicBox, ILocalizedModType
    {
        public override int MusicBoxTile => ModContent.TileType<Tiles.MusicBoxes.TlotdTitleMusicBox>();
        public new string LocalizationCategory => "Items.Placeables.MusicBoxes";
    }
}
