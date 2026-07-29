using UnityEngine;

namespace Game.Enemy
{
    public class RangedEnemy : BaseEnemy
    {
        [SerializeField] private ProjectileData projectileData;
        [SerializeField] private float fireRate = 1.5f;
        private float lastFireTime = -999f;

        private void Update()
        {
            if (targetTransform == null || enemyData == null) return;

            float distance = Vector2.Distance(transform.position, targetTransform.position);
            if (distance <= enemyData.attackRange)
            {
                if (Time.time >= lastFireTime + fireRate)
                {
                    PerformAttack();
                    lastFireTime = Time.time;
                }
            }
            else
            {
                transform.position = Vector2.MoveTowards(transform.position, targetTransform.position, enemyData.moveSpeed * Time.deltaTime);
            }
        }

        protected override void PerformAttack()
        {
            if (projectileData == null || projectileData.prefab == null || targetTransform == null) return;

            Vector2 dir = (targetTransform.position - transform.position).normalized;
            GameObject projObj = Instantiate(projectileData.prefab, transform.position, Quaternion.identity);
            var proj = projObj.GetComponent<Projectile>();
            if (proj != null)
            {
                proj.Initialize(projectileData, dir);
            }
        }
    }
}
