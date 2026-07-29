using UnityEngine;
using Game.Core;
using Game.Item;

namespace Game.Enemy
{
    [RequireComponent(typeof(HealthComponent))]
    public abstract class BaseEnemy : MonoBehaviour
    {
        [SerializeField] protected EnemyData enemyData;
        protected HealthComponent healthComponent;
        protected Transform targetTransform;

        protected virtual void Awake()
        {
            healthComponent = GetComponent<HealthComponent>();
        }

        protected virtual void Start()
        {
            if (enemyData != null)
            {
                healthComponent.Initialize(enemyData.maxHealth);
            }

            healthComponent.OnDeath += HandleDeath;

            var player = GameObject.FindGameObjectWithTag("Player");
            if (player != null)
            {
                targetTransform = player.transform;
            }
        }

        protected virtual void OnDestroy()
        {
            if (healthComponent != null)
            {
                healthComponent.OnDeath -= HandleDeath;
            }
        }

        protected virtual void HandleDeath()
        {
            if (targetTransform != null && enemyData != null)
            {
                var inventory = targetTransform.GetComponent<InventoryComponent>();
                if (inventory != null)
                {
                    inventory.AddGold(enemyData.goldReward);
                }
            }
            Destroy(gameObject);
        }

        protected abstract void PerformAttack();
    }
}
