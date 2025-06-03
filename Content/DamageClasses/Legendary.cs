using Terraria.ModLoader;

namespace tlotd.Content.DamageClasses
{
    public class Legendary : DamageClass
    {
        internal static Legendary Instance;

        public override void Load() => Instance = this;
        public override void Unload() => Instance = null;

        public override StatInheritanceData GetModifierInheritance(DamageClass damageClass)
        {
            if (damageClass == Melee || damageClass == Generic)
                return StatInheritanceData.Full;

            return StatInheritanceData.None;
        }
        public override bool GetEffectInheritance(DamageClass damageClass) => damageClass == Melee;
    }
}