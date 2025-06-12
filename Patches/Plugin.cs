using BepInEx;
using System.ComponentModel;
using Utilla.Attributes;
using UnityEngine;
using System.Collections;

namespace Coal.Patches
{
    [Description(Coal.PluginInfo.Description)]
    [BepInPlugin(Coal.PluginInfo.GUID, Coal.PluginInfo.Name, Coal.PluginInfo.Version)]
    [BepInDependency("org.legoandmars.gorillatag.utilla", "1.6.16")]
    public class HarmonyPatches : BaseUnityPlugin
    {
        private void OnEnable()
        {
            Menu.ApplyHarmonyPatches();
        }

        private void OnDisable()
        {
            Menu.RemoveHarmonyPatches();
        }
    }
}
