using BepInEx;
using PieceManager;
using UnityEngine;
using HarmonyLib;
using ServerSync;


namespace CoolerWorkbench
{
    [BepInPlugin(ModGUID, ModName, ModVersion)]
    public class CoolerWorkbench : BaseUnityPlugin
    {
        private const string ModName = "CoolerWorkbench";
        private const string ModVersion = "1.3.0";
        private const string Author = "Bento";
        private const string ModGUID = Author + "." + ModName;

        private void Awake()
        {   BuildPiece coolerWorkbench = new("cooler_workbench", "CoolerWorkbench");
            coolerWorkbench.Name.English("Cooler Workbench");
            coolerWorkbench.Description.English("Harder, better, faster, stronger. Ok maybe just a bit harder and a tiny bit better, but definitely cooler.");
            coolerWorkbench.RequiredItems.Add("FineWood", 4, true);
            coolerWorkbench.RequiredItems.Add("Iron", 2, true);
            coolerWorkbench.RequiredItems.Add("RoundLog", 4, true);
            coolerWorkbench.RequiredItems.Add("Tar", 2, true);
            MaterialReplacer.RegisterGameObjectForMatSwap(coolerWorkbench.Prefab, false);
        }
    }
}