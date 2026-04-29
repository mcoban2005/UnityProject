## Week 6 — Mini FPS Polishing (Weapon/Ammo, Crosshair, Enemy AI)

### Hedef
Week 2-5’teki FPS iskeletini “daha oyun gibi” hale getirmek:
- Silah sistemi: `ammo`, `rate of fire`, `reload`
- Nişan/crosshair hedef algılama (raycast)
- Enemy davranışı: basit kovalamaca + yakın temas ile hasar

### Konular
- New Input System ile ek aksiyon: `Reload`
- Cooldown + reload state makinesi
- UI güncellemesi (ammo counter)
- UI crosshair hedef rengi (raycast hit kontrolü)
- Basit enemy chase (NavMesh olmadan)

### Mini Görev (teslim)
1. Player’da:
   - `FpsInputMovementCC` aktif
   - `HitscanWeaponAmmo` ateş eder
   - `Reload` ile ammo dolsun
2. UI:
   - Crosshair hedef üzerindeyken farklı renge geçsin
   - Ammo counter güncellensin
3. Enemy:
   - Player’ı kovalasın
   - Yakın menzilde Player’a `Health` üzerinden hasar versin

### Kurulum (kısa, pratik)
#### 1) Input Actions
`Assets/Input/Player/PlayerControls.inputactions` içine `Reload` aksiyonu eklenir (klavye: `G`).

`HitscanWeaponAmmo` script’inde Inspector’dan:
- `fireAction` -> `Player/Fire`
- `reloadAction` -> `Player/Reload`
- `firePoint` -> genelde `Camera`

#### 2) Player
- Player objesine `Health` (oyuncu) ekli olmalı.
- Player objesine veya weapon pivot’una `HitscanWeaponAmmo` ekle.

#### 3) UI
- Canvas altına:
  - bir `Text` ile ammo counter için `AmmoCounterUI`
  - bir `Image` ile crosshair için `CrosshairTargetUI`

`AmmoCounterUI` Inspector:
- `weapon` -> Player’daki `HitscanWeaponAmmo`
- `ammoText` -> ammo counter Text objesi

`CrosshairTargetUI` Inspector:
- `playerCamera` -> Player camera
- `crosshairImage` -> UI Image objesi

#### 4) Enemy
- Enemy prefab:
  - `Health` bileşeni (mevcut Week 3 Health)
  - `EnemyChaseAI`
- Player objeni tag olarak `Player` olmalı (script bu tag’i arar).

### Bu hafta eklenecek örnek kodlar
- `Scripts/HitscanWeaponAmmo.cs`
- `Scripts/AmmoCounterUI.cs`
- `Scripts/CrosshairTargetUI.cs`
- `Scripts/EnemyChaseAI.cs`

