using System.Collections.Generic;
using UnityEngine;

namespace Game.Item
{
    public class InventoryComponent : MonoBehaviour
    {
        [SerializeField] private CurrencyData currencyData = new CurrencyData();
        private List<ItemData> items = new List<ItemData>();

        public CurrencyData Currency => currencyData;
        public IReadOnlyList<ItemData> Items => items.AsReadOnly();

        public void AddItem(ItemData itemData)
        {
            if (itemData == null) return;
            items.Add(itemData);
            itemData.ApplyAllEffects(gameObject);
        }

        public void AddGold(int amount)
        {
            currencyData.AddGold(amount);
        }
    }
}
