using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace tlotd.Content.Items.Mounts
{
    public class PlutoniumFueledNuclearReactor : ModItem, ILocalizedModType
    {
        public new string LocalizationCategory => "Items.Mounts";
        public override void SetStaticDefaults()
        {

        }

        public override void SetDefaults()
        {
            Item.width = 32;
            Item.height = 32;
            Item.useTime = 20;
            Item.useAnimation = 20;
            Item.useStyle = ItemUseStyleID.HoldUp;

            Item.value = Item.sellPrice(gold: 2);
            Item.rare = ItemRarityID.LightRed;

            Item.UseSound = SoundID.NPCHit56;
            Item.noMelee = true;
            Item.mountType = ModContent.MountType<DeLorean>();
        }
    }
}
