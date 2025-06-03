using System.Collections.Generic;
using System.Linq;
using tlotd.Content.LtdPlayer;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Audio;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace tlotd.Content.Items.PlayerUpgrades
{
    public class PactWithTheVoid : ModItem, ILocalizedModType
    {
        public new string LocalizationCategory => "Items.PlayerUpgrades";

        public const int ManaBoost = 100;
        public override LocalizedText Tooltip => base.Tooltip.WithFormatArgs(ManaBoost);
        public static readonly SoundStyle UseSound = new("tlotd/Content/Sounds/Item/EffigyOfTheWoundedDeityConsume");
        public override void SetStaticDefaults()
        {
            // For some reason Life/Mana boosting items are in this set (along with Magic Mirror+)
            ItemID.Sets.SortingPriorityBossSpawns[Type] = 21; // Mana Crystal
        }

        public override void SetDefaults()
        {
            Item.width = 22;
            Item.height = 30;
            Item.useAnimation = 30;
            Item.rare = ItemRarityID.Red;
            Item.useTime = 30;
            Item.useStyle = ItemUseStyleID.HoldUp;
            Item.UseSound = UseSound;
            Item.consumable = true;
        }

        public override bool CanUseItem(Player player){
            TlotdPlayer modPlayer = player.Tlotd();
            if ((player.ConsumedManaCrystals == Player.ManaCrystalMax) && (!modPlayer.pactWithTheVoid)) {
                return true;
            }
            return false;
        }

        public override bool? UseItem(Player player)
        {
            TlotdPlayer modPlayer = player.Tlotd();
            if (player.itemAnimation > 0 && player.itemTime == 0)
            {
                player.itemTime = Item.useTime;
                player.UseManaMaxIncreasingItem(ManaBoost);
                modPlayer.pactWithTheVoid = true;
            }
            return true;
        }

        public override void AddRecipes()
        {
            CreateRecipe().
                AddIngredient(ItemID.FragmentNebula, 20).
                AddIngredient(ItemID.FallenStar, 20).
                AddTile(TileID.LunarCraftingStation).
                Register();
        }
    }
}
