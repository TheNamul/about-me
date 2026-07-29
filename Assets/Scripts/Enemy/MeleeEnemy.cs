using UnityEngine;
using Game.Core;

namespace Game.Enemy
{
    public class MeleeEnemy : BaseEnemy
    {
        [SerializeField] private float attackCooldown = 1.0f;
        private float lastAttackTime = -999f;

        private void Update()
        {
            if (targetTransform == null || enemyData == null) return;

            float distance = Vector2.Distance(transform.position, targetTransform.position);
            if (distance <= enemyData.attackRange)
            {
                if (Time.time >= lastAttackTime + attackCooldown)
                {
                    PerformAttack();
                    lastAttackTime = Time.time;
                }
            }
            else
            {
                transform.position = Vector2.MoveTowards(transform.position, targetTransform.position, enemyData.moveSpeed * Time.deltaTime);
            }
        }

        protected override void PerformAttack()
        {
            if (targetTransform == null) return;
            var health = targetTransform.GetComponent<HealthComponent>();
            if (health != null)
            {
                health.TakeDamage(enemyData.attackDamage);
            }
        }
    }
}
