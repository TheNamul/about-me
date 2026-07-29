using UnityEngine;
using Game.Core;
using Game.Item;

namespace Game.Player
{
    [RequireComponent(typeof(DashComponent), typeof(HealthComponent), typeof(InventoryComponent))]
    public class PlayerController : MonoBehaviour, IDashable
    {
        [SerializeField] private PlayerData playerData;

        private DashComponent dashComponent;
        private HealthComponent healthComponent;
        private InventoryComponent inventoryComponent;
        private Rigidbody2D rb;
        private Vector2 moveInput;

        public bool CanDash => dashComponent != null && dashComponent.CanDash;

        private void Awake()
        {
            dashComponent = GetComponent<DashComponent>();
            healthComponent = GetComponent<HealthComponent>();
            inventoryComponent = GetComponent<InventoryComponent>();
            rb = GetComponent<Rigidbody2D>();

            if (playerData != null)
            {
                dashComponent.Initialize(playerData.dashCooldown, playerData.dashInvincibilityDuration);
                healthComponent.Initialize(playerData.maxHealth);
            }
        }

        private void Update()
        {
            moveInput.x = Input.GetAxisRaw("Horizontal");
            moveInput.y = Input.GetAxisRaw("Vertical");
            moveInput = moveInput.normalized;

            if (Input.GetKeyDown(KeyCode.Space))
            {
                Dash();
            }
        }

        private void FixedUpdate()
        {
            float speed = playerData != null ? playerData.moveSpeed : 5f;
            rb.velocity = moveInput * speed;
        }

        public void Dash()
        {
            if (dashComponent != null && dashComponent.TryDash())
            {
                float speedMult = playerData != null ? playerData.dashSpeedMultiplier : 2.5f;
                rb.velocity = moveInput * (playerData != null ? playerData.moveSpeed : 5f) * speedMult;
            }
        }
    }
}