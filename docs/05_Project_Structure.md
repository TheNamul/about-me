# Project Structure

## Folder Structure
- [ ] Assets/Scripts/Core/ — 공통 인터페이스(IDashable) 및 범용 컴포넌트(HealthComponent, DashComponent) 배치
- [ ] Assets/Scripts/Player/ — 플레이어 제어 로직(PlayerController) 배치
- [ ] Assets/Scripts/Enemy/ — 적 관련 클래스(BaseEnemy, MeleeEnemy, RangedEnemy) 및 투사체(Projectile) 배치
- [ ] Assets/Scripts/Item/ — 아이템, 인벤토리, 재화 관련 클래스(InventoryComponent, CurrencyData, ItemData, IItemEffect, StatBoostEffect) 배치
- [ ] Assets/Scripts/UI/ — 체력바, 인벤토리 UI, 재화 표시 등 UI 관련 스크립트 배치

## Assembly Definitions
- [ ] Game.Core.asmdef — 범용 모듈 및 인터페이스 (의존성 없음)
- [ ] Game.Item.asmdef — 아이템 및 재화 시스템 (Game.Core 참조)
- [ ] Game.Player.asmdef — 플레이어 컨트롤러 및 컴포넌트 (Game.Core, Game.Item 참조)
- [ ] Game.Enemy.asmdef — 적 AI 및 투사체 로직 (Game.Core, Game.Item 참조)
- [ ] Game.UI.asmdef — UI 표시 및 이벤트 바인딩 (Game.Core, Game.Player, Game.Item 참조)