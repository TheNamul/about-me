using UnityEngine;

namespace Game.Enemy
{
    [CreateAssetMenu(fileName = "ProjectileData", menuName = "Game/Data/ProjectileData")]
    public class ProjectileData : ScriptableObject
    {
        public float speed = 8f;
        public float damage = 10f;
        public float range = 10f;
        public bool isPenetrating = false;
        public GameObject prefab;
    }
}
