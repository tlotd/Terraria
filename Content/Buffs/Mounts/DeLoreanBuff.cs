using Terraria;
using Terraria.ModLoader;
using tlotd.Content.Items.Mounts;

namespace tlotd.Content.Buffs.Mounts
{
    public class DeLoreanBuff : ModBuff
    {
        public override void SetStaticDefaults()
        {
            Main.buffNoTimeDisplay[Type] = true;
            Main.buffNoSave[Type] = true;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.mount.SetMount(ModContent.MountType<DeLorean>(), player);
            player.buffTime[buffIndex] = 10;
        }
    }
}