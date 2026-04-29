## Week 4 — UI (Health Bar) + Basit Game Loop

### Hedef
Oyun durumunu (Playing / GameOver) yönetmek ve Health değerini UI üzerinde göstermek.

### Öğrenme çıktıları
- UI’de bir `Slider` değerini runtime’da Health’a bağlarsın
- `GameOver` gibi state geçişlerini merkezi bir manager ile yönetirsin
- Sağlık sistemi ölümü event ile yayınlar, UI/State bunu dinler

### Konular
- Unity UI: `Canvas`, `Slider`
- Komponent referansları: Inspector bağlama
- Event tabanlı akış: `Health.OnAnyHealthDied`
- `Time.timeScale = 0` ile “oyunu dondurma”

### Unity kurulum (kısa)
- Sahneye UI ekle:
  1. `Canvas` oluştur
  2. `Slider` ekle (Health bar gibi konumlandır)
  3. (Opsiyonel) Game Over için bir panel/label oluştur (`gameOverPanel`)
- `HealthSliderUI` kur:
  - `HealthSliderUI` script’ini Slider objesine ekle
  - `targetHealth` -> Player’daki `Health`
  - `slider` -> Slider referansı
- `GameStateController` kur:
  1. Boş bir `GameObject` (ör. `GameState`) oluştur
  2. `GameStateController` ekle
  3. `playerHealth` -> Player’daki `Health`
  4. `gameOverPanel` -> opsiyonel panel objesi
  5. `freezeTimeOnGameOver` -> true (önerilir)

### Mini Görev (checkpoint)
- Player Health düşer düşmez slider azalıyor
- Player ölünce:
  - GameOver log görünüyor
  - (opsiyonel) panel açılıyor
  - timeScale 0 oluyor

### Bu hafta eklenecek örnek kodlar (repo içi)
- `Scripts/HealthSliderUI.cs`
- `Scripts/GameStateController.cs`

### Notlar (kritik detay)
- `GameStateController` sadece `playerHealth` referansı ile belirlenen Health instance’ının ölümünü GameOver sayar.
- Bu nedenle Inspector’da `playerHealth` bağlamayı atlama.


