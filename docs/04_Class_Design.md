# Class Design

## Classes
- [ ] PlayerController — 플레이어의 입력 처리, 이동, 공격 조작을 총괄하는 중심 클래스 (IDashable 구현, DashComponent 및 HealthComponent 보유)
- [ ] IDashable — 대시 가능 개체를 위한 인터페이스 (Dash() 메서드 정의)
- [ ] DashComponent — 대시 쿨다운(1.2초) 및 무적 시간(0.3초) 로직을 담당하는 컴포넌트
- [ ] HealthComponent — 체력 관리, 피격 처리 및 넉백 물리 효과 적용을 담당하는 컴포넌트
- [ ] Projectile — 원거리 공격 시 생성되어 지정 방향으로 이동하는 투사체 오브젝트 클래스
- [ ] BaseEnemy — 몬스터의 공통 스탯, 체력, 사망 시 골드 지급 이벤트를 관리하는 추상/기반 클래스
- [ ] MeleeEnemy — BaseEnemy를 상속받으며 근접 공격 근처 진입 및 판정을 담당하는 클래스
- [ ] RangedEnemy — BaseEnemy를 상속받으며 원거리 투사체 발사 로직을 담당하는 클래스
- [ ] InventoryComponent / CurrencyData — 플레이어가 소지한 골드 및 획득 아이템 목록을 관리하는 클래스
- [ ] ItemData (ScriptableObject) — 아이템의 기본 정보(이름, 가격, 아이콘 등)와 적용할 IItemEffect 목록을 보유하는 데이터 클래스
- [ ] IItemEffect — 아이템 구매/사용 시 플레이어 능력치를 강화하는 효과 인터페이스
- [ ] StatBoostEffect — IItemEffect를 구현하여 플레이어의 특정 능력치를 상승시키는 효과 클래스

## Relationships
- [ ] PlayerController는 IDashable 인터페이스를 구현한다.
- [ ] PlayerController는 DashComponent와 HealthComponent를 컴포지션으로 소유한다.
- [ ] MeleeEnemy와 RangedEnemy는 BaseEnemy 클래스를 상속받는다.
- [ ] ItemData는 하나 이상의 IItemEffect 구현체(예: StatBoostEffect)를 포함하여 컴포지션 관계를 가진다.
- [ ] BaseEnemy 처치 시 CurrencyData(또는 InventoryComponent)로 골드 수치 증가 이벤트를 전달한다.