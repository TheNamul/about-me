# ScriptableObjects

## Data Assets
- [ ] PlayerData — 플레이어 기본 스탯(최대 체력, 이동 속도, 대시 쿨다운, 대시 무적 시간 등)을 정의하며 PlayerController 및 DashComponent에서 참조하는 데이터 에셋
- [ ] EnemyData — 몬스터 공통 스탯(최대 체력, 이동 속도, 공격력, 처치 시 지급 골드량 등)을 정의하며 BaseEnemy, MeleeEnemy, RangedEnemy에서 참조하는 데이터 에셋
- [ ] ItemData — 아이템 기본 정보(아이템 이름, 설명, 가격, 아이콘 프리팹) 및 적용할 IItemEffect(StatBoostEffect 등) 목록을 관리하며 InventoryComponent 및 상점 시스템에서 참조하는 데이터 에셋
- [ ] ProjectileData — 투사체의 속도, 데미지, 사거리, 관통 여부 및 그래픽 프리팹 정보를 정의하며 Projectile 및 RangedEnemy에서 참조하는 데이터 에셋