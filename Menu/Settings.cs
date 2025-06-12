using Coal.Classes;
using System.Collections.Generic;
using UnityEngine;
using static Coal.Menu.Main;

namespace Coal
{
    internal class Settings
    {
        public enum SpeedTypes
        {
            Slow,
            Normal,
            Fast,
            SuperFast
        }

        public static readonly Dictionary<SpeedTypes, (float JumpMultiplier, float MaxJumpSpeed)> speedValues =
            new Dictionary<SpeedTypes, (float, float)>
            {
                { SpeedTypes.Slow, (0.9f, 6f) },
                { SpeedTypes.Normal, (1.1f, 6.5f) },
                { SpeedTypes.Fast, (1.2f, 6.7f) },
                { SpeedTypes.SuperFast, (1.5f, 7.4f) }
            };

        public static ExtGradient backgroundColor = new ExtGradient
        {
            colors = GetSolidGradient(HexToColor("#3C0061"))
        };
        public static ExtGradient[] buttonColors = new ExtGradient[]
        {
            new ExtGradient{colors = GetSolidGradient(Color.black)}, // Disabled
            new ExtGradient{colors = GetSolidGradient(Color.cyan)} // Enabled
        };
        public static Color[] textColors = new Color[]
        {
            Color.white, // Disabled
            Color.black // Enabled
        };

        public static Font currentFont = (Resources.GetBuiltinResource(typeof(Font), "Arial.ttf") as Font);

        public static bool fpsCounter = true;
        public static bool disconnectButton = true;
        public static bool rightHanded = false;
        public static bool disableNotifications = false;

        public static KeyCode keyboardButton = KeyCode.Q;

        public static Vector3 menuSize = new Vector3(0.1f, 1f, 1f); // Depth, Width, Height
        public static int buttonsPerPage = 8;
    }
}
