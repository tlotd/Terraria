using System.Collections.Generic;
using tlotd.Content.LtdPlayer;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria;
using Terraria.GameContent;
using Terraria.ModLoader;

namespace tlotd.Content.UI.PlayerResourceSets
{
    public class TlotdResourceOverlay : ModResourceOverlay
    {
        // Most of this is taken from ExampleMod. See that for additional explanations.
        private Dictionary<string, Asset<Texture2D>> vanillaAssetCache = new();
        public string baseFolder = "tlotd/Content/UI/ResourceSets/";

        // Determines which health UI to draw based on player upgrades.
        public string LifeTexturePath()
        {
            string folder = $"{baseFolder}HP";
            TlotdPlayer modPlayer = Main.LocalPlayer.Tlotd();
            if (modPlayer.effigyWoundedDeity)
                return folder + "EffigyOfTheWoundedDeity";
            return string.Empty;
        }

        // Determines which mana UI to draw based on player upgrades.
        public string ManaTexturePath()
        {
            string folder = $"{baseFolder}MP";
            TlotdPlayer modPlayer = Main.LocalPlayer.Tlotd();
            if (modPlayer.pactWithTheVoid)
                return folder + "PactWithTheVoid";
            return string.Empty;
        }

        public override void PostDrawResource(ResourceOverlayDrawContext context)
        {
            Asset<Texture2D> asset = context.texture;
            // Vanilla texture paths
            string fancyFolder = "Images/UI/PlayerResourceSets/FancyClassic/";
            string barsFolder = "Images/UI/PlayerResourceSets/HorizontalBars/";

            if (ManaTexturePath() != string.Empty)
            {
                // Draw stars for Classic and Fancy
                if (asset == TextureAssets.Mana || CompareAssets(asset, fancyFolder + "Star_Fill"))
                {
                    context.texture = ModContent.Request<Texture2D>(ManaTexturePath() + "Star");
                    context.Draw();
                }
                // Draw mana bars
                else if (CompareAssets(asset, barsFolder + "MP_Fill"))
                {
                    context.texture = ModContent.Request<Texture2D>(ManaTexturePath() + "Bar");
                    context.Draw();
                }
            }

            if (LifeTexturePath() == string.Empty)
                return;

            // Draw hearts for Classic and Fancy
            if (asset == TextureAssets.Heart || asset == TextureAssets.Heart2 || CompareAssets(asset, fancyFolder + "Heart_Fill") || CompareAssets(asset, fancyFolder + "Heart_Fill_B"))
            {
                context.texture = ModContent.Request<Texture2D>(LifeTexturePath() + "Heart");
                context.Draw();
            }
            // Draw health bars
            else if (CompareAssets(asset, barsFolder + "HP_Fill") || CompareAssets(asset, barsFolder + "HP_Fill_Honey"))
            {
                context.texture = ModContent.Request<Texture2D>(LifeTexturePath() + "Bar");
                context.Draw();
            }
        }

        private bool CompareAssets(Asset<Texture2D> currentAsset, string compareAssetPath)
        {
            if (!vanillaAssetCache.TryGetValue(compareAssetPath, out var asset))
                asset = vanillaAssetCache[compareAssetPath] = Main.Assets.Request<Texture2D>(compareAssetPath);

            return currentAsset == asset;
        }
    }
}
