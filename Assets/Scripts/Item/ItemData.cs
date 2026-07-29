using System.Collections.Generic;
using UnityEngine;

namespace Game.Item
{
    [CreateAssetMenu(fileName = "ItemData", menuName = "Game/Data/ItemData")]
    public class ItemData : ScriptableObject
    {
        public string itemName;
        [TextArea] public string description;
        public int price;
        public Sprite icon;
        public GameObject prefab;

        [SerializeReference]
        public List<IItemEffect> effects = new List<IItemEffect>();

        public void ApplyAllEffects(GameObject target)
        {
            foreach (var effect in effects)
            {
                effect?.ApplyEffect(target);
            }
        }
    }
}
