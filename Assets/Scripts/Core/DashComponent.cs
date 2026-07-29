using UnityEngine;

namespace Game.Core
{
    public class DashComponent : MonoBehaviour
    {
        [SerializeField] private float dashCooldown = 1.2f;
        [SerializeField] private float dashInvincibilityDuration = 0.3f;

        private float lastDashTime = -999f;
        private bool isInvincible = false;

        public bool CanDash => Time.time >= lastDashTime + dashCooldown;
        public bool IsInvincible => isInvincible;

        public void Initialize(float cooldown, float invincibilityDuration)
        {
            dashCooldown = cooldown;
            dashInvincibilityDuration = invincibilityDuration;
        }

        public bool TryDash()
        {
            if (!CanDash) return false;

            lastDashTime = Time.time;
            StartCoroutine(InvincibilityRoutine());
            return true;
        }

        private System.Collections.IEnumerator InvincibilityRoutine()
        {
            isInvincible = true;
            yield return new WaitForSeconds(dashInvincibilityDuration);
            isInvincible = false;
        }
    }
}
