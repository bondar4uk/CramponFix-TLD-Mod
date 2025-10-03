using MelonLoader;
using Il2Cpp;
using System;

namespace CramponFix
{
    public class Main : MelonMod
    {
        public override void OnInitializeMelon()
        {
            MelonLogger.Msg("CramponFix loaded! Applying stats fix...");
            ApplyCramponStatsFix();
        }

        private static void ApplyCramponStatsFix()
        {
            try
            {
                var improvisedCrampons = GearItem.LoadGearItemPrefab("GEAR_ImprovisedCrampons").GetComponent<ClimbingBuff>();

                improvisedCrampons.m_SprainRollOddsModifier = 70;
                improvisedCrampons.m_StaminaPerSecondModifier = 60;

                MelonLogger.Msg("Updated GEAR_ImprovisedCrampons: Sprain 70, Stamina 60.");

                var regularCrampons = GearItem.LoadGearItemPrefab("GEAR_Crampons").GetComponent<ClimbingBuff>();
                regularCrampons.m_SprainRollOddsModifier = 50;
                regularCrampons.m_StaminaPerSecondModifier = 40;

                MelonLogger.Msg("Updated GEAR_Crampons: Sprain 50, Stamina 40.");
            }
            catch (Exception ex)
            {
                MelonLogger.Error($"CramponFix failed to apply stats: {ex.Message}");
            }
        }
    }
}