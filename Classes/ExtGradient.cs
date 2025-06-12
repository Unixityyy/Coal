using UnityEngine;

namespace Coal.Classes
{
    public class ExtGradient
    {
        public GradientColorKey[] colors = new GradientColorKey[]
        {
            new GradientColorKey(HexToColor("#3C0061"), 0f),
            new GradientColorKey(HexToColor("#61009E"), 0.5f),
            new GradientColorKey(HexToColor("#3C0061"), 1f)
        };

        public bool isRainbow = false;
        public bool copyRigColors = false;

        // Helper method to convert hex to Color
        private static Color HexToColor(string hex)
        {
            Color color;
            ColorUtility.TryParseHtmlString(hex, out color);
            return color;
        }
    }
}
