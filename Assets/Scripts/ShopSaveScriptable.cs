using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ShopSystem
{
    [CreateAssetMenu(fileName = "ShopData",menuName = "Scriptable/Create ShopData")]
    public class ShopSaveScriptable : ScriptableObject
    {
        public ShopItem[] shopItems;
    }
    [System.Serializable]
    public class ShopItem
    {
        public string itemName;
        public int unlockedCost;
        public int unlockedLevel;
        public UpgradeInfo[] upgradeInfo;
    }
    [System.Serializable]
    public class UpgradeInfo
    {
        public int unlockCost;
        public int speed;
        public int time;
        public int jump;
        public int coinMultiplier;
    }
}