using UnityEngine;

namespace Game.Enemy
{
    [CreateAssetMenu(fileName = "EnemyData", menuName = "Game/Data/EnemyData")]
    public class EnemyData : ScriptableObject
    {
        public string enemyName;
        public float maxHealth = 50f;
        public float moveSpeed = 3f;
        public float attackDamage = 10f;
        public float attackRange = 1.5f;
        public int goldReward = 15;
    }
}
