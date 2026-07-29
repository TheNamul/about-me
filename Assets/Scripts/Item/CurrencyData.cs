using System;
using UnityEngine;

namespace Game.Item
{
    [System.Serializable]
    public class CurrencyData
    {
        [SerializeField] private int gold;
        public int Gold => gold;

        public event Action<int> OnGoldChanged;

        public void AddGold(int amount)
        {
            if (amount <= 0) return;
            gold += amount;
            OnGoldChanged?.Invoke(gold);
        }

        public bool TrySpendGold(int amount)
        {
            if (amount <= 0 || gold < amount) return false;
            gold -= amount;
            OnGoldChanged?.Invoke(gold);
            return true;
        }
    }
}
