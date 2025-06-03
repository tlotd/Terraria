using System.Collections.Generic;
using System.Reflection;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

using TlotdTitleMusicBox = tlotd.Content.Items.Placeables.MusicBoxes.TlotdTitleMusicBox;
using LordOfTheRingsMainThemeMusicBox = tlotd.Content.Items.Placeables.MusicBoxes.LordOfTheRingsMainThemeMusicBox;

namespace tlotd.Content
{
    public class MusicBoxRegistry : ModSystem
    {
        private static void AddMusicBox(string musicFile, int itemID, int tileID)
        {
            Mod musicMod = tlotd.Instance;
            int musicID = MusicLoader.GetMusicSlot(musicMod, musicFile);
            MusicLoader.AddMusicBox(musicMod, musicID, itemID, tileID);
        }

        public override void PostSetupContent()
        {
            if (!Main.dedServ)
            {
                AddMusicBox("Content/Sounds/Music/TlotdTitle", ModContent.ItemType<TlotdTitleMusicBox>(), ModContent.TileType<Tiles.MusicBoxes.TlotdTitleMusicBox>());
                AddMusicBox("Content/Sounds/Music/LordOfTheRingsMainTheme", ModContent.ItemType<LordOfTheRingsMainThemeMusicBox>(), ModContent.TileType<Tiles.MusicBoxes.LordOfTheRingsMainThemeMusicBox>());
            }
        }
    }
}
