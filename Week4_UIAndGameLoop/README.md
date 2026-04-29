## Week 4 — UI (Health Bar) + Basit Game Loop

### Hedef
Oyun durumunu (Playing / GameOver) yönetmek ve Health değerini UI üzerinde göstermek.

### Konular
- Unity UI: `Canvas`, `Slider` (veya `Text`)
- UI güncelleme (frame-by-frame veya event yaklaşımı)
- Basit state yönetimi

### Mini Görev
- Health düşerken slider güncellensin
- Health 0 olunca GameOver log / UI tetiklensin

### Bu hafta eklenecek örnek kodlar
- `Scripts/HealthSliderUI.cs`
- `Scripts/GameStateController.cs`

### Unity kurulum (kısa)
- `HealthSliderUI`:
  - `targetHealth` -> oyuncunun `Health` bileşeni
  - `slider` -> UI `Slider` (Canvas içindeki)
- `GameStateController`:
  - `playerHealth` -> oyuncunun `Health` bileşeni
  - `gameOverPanel` (opsiyonel) -> Game Over UI objesi
  - `freezeTimeOnGameOver` (opsiyonel) -> true/false


