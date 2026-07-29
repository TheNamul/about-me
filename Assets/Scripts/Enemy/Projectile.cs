using UnityEngine;
using Game.Core;

namespace Game.Enemy
{
    public class Projectile : MonoBehaviour
    {
        private ProjectileData data;
        private Vector2 direction;
        private Vector3 startPosition;

        public void Initialize(ProjectileData projectileData, Vector2 dir)
        {
            data = projectileData;
            direction = dir.normalized;
            startPosition = transform.position;
        }

        private void Update()
        {
            if (data == null) return;

            transform.Translate(direction * (data.speed * Time.deltaTime), Space.World);

            if (Vector3.Distance(startPosition, transform.position) >= data.range)
            {
                Destroy(gameObject);
            }
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (data == null) return;

            var health = collision.GetComponent<HealthComponent>();
            if (health != null)
            {
                health.TakeDamage(data.damage);
                if (!data.isPenetrating)
                {
                    Destroy(gameObject);
                }
            }
        }
    }
}
