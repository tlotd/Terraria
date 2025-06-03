using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ModLoader.IO;
using Microsoft.Xna.Framework;

using tlotd.Content.Items.PlayerUpgrades;

using System;
using System.Collections.Generic;
using System.Linq;

namespace tlotd.Content.LtdPlayer
{
    public partial class TlotdPlayer : ModPlayer
    {
        #region Variables

        #region Permanent Buff
        public bool effigyWoundedDeity = false;
        public bool pactWithTheVoid = false;
        #endregion

        #region Saving And Loading
        public override void Initialize()
        {
            effigyWoundedDeity = false;
            pactWithTheVoid = false;
        }

        public override void SaveData(TagCompound tag)
        {
            var boost = new List<string>();
            boost.AddWithCondition("EffigyOfTheWoundedDeity", effigyWoundedDeity);
            boost.AddWithCondition("PactWithTheVoid", pactWithTheVoid);
            tag["boost"] = boost;
        }

        public override void LoadData(TagCompound tag)
        {
            var boost = tag.GetList<string>("boost");
            effigyWoundedDeity = boost.Contains("EffigyOfTheWoundedDeity");
            pactWithTheVoid = boost.Contains("PactWithTheVoid");
        }
        #endregion

        #region Modify Max Health and Mana
        public override void ModifyMaxStats(out StatModifier health, out StatModifier mana)
        {
            health = StatModifier.Default;
            health.Base = effigyWoundedDeity.ToInt() * EffigyOfTheWoundedDeity.LifeBoost;

            mana = StatModifier.Default;
            mana.Base = pactWithTheVoid.ToInt() * PactWithTheVoid.ManaBoost;
        }
        #endregion
        #endregion
    }
}
