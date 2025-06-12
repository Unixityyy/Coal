using GorillaLocomotion;
using System;
using System.Collections.Generic;
using System.Text;
using static Coal.Mods.SettingsMods;
using static Coal.Settings;

namespace Coal.Mods
{
    public class Movement
    {
        public static void SpeedBoost()
        {
            SpeedTypes speed = (SpeedTypes)currentSpeed;
            (float jumpMultiplier, float maxJumpSpeed) = speedValues[speed];

            GTPlayer.Instance.jumpMultiplier = jumpMultiplier;
            GTPlayer.Instance.maxJumpSpeed = maxJumpSpeed;
        }
    }
}
