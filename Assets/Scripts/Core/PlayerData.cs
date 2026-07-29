using UnityEngine;

namespace Game.Core
{
    [CreateAssetMenu(fileName = "PlayerData", menuName = "Game/Data/PlayerData")]
    public class PlayerData : ScriptableObject
    {
        public float maxHealth = 100f;
        public float moveSpeed = 5f;
        public float dashCooldown = 1.2f;
        public float dashInvincibilityDuration = 0.3f;
        public float dashSpeedMultiplier = 2.5f;
    }
}
