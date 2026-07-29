using UnityEngine;
using Game.Core;

namespace Game.Item
{
    [System.Serializable]
    public class StatBoostEffect : IItemEffect
    {
        public enum StatType { MaxHealth, MoveSpeed }

        [SerializeField] private StatType statType;
        [SerializeField] private float value;

        public void ApplyEffect(GameObject target)
        {
            if (target == null) return;

            switch (statType)
            {
                case StatType.MaxHealth:
                    var health = target.GetComponent<HealthComponent>();
                    if (health != null) health.Heal(value);
                    break;
                case StatType.MoveSpeed:
                    // Handle speed boost logic
                    break;
            }
        }
    }
}
