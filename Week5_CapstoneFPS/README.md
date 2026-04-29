## Week 5 — Capstone: Mini FPS (Spawn + Skor + Game Over)

### Hedef
Week 2-4’teki parçaları birleştirerek mini bir FPS yapısı kurmak:
- Enemy spawn
- Raycast ile vurma
- Health ile ölüm
- Skor ve Game Over akışı

### Konular
- Spawner mantığı (`Instantiate`)
- Skor yönetimi
- Restart (opsiyonel)

### Mini Görev
- Enemy’ler belirli aralıklarla gelsin
- Vuran oyuncu skor kazansın
- Oyuncu ölünce Game Over olsun
- Restart ile başa dön (opsiyonel)

### Bu hafta eklenecek örnek kodlar
- `Scripts/EnemySpawner.cs`
- `Scripts/ScoreManager.cs`
- `Scripts/RestartInput.cs` (opsiyonel)

### Capstone kurulum akışı (kısa)
1. Player objesine ekle:
   - `CharacterController` (FpsInputMovementCC çalışır)
   - `FpsInputMovementCC` (input binding’leri Inspector’dan bağla)
   - `HitscanShooter` (fireAction -> `Player/Fire`)
   - `Health` (oyuncunun ölümü GameOver’u tetikler)
2. Enemy prefab:
   - `Health` (varsayılan `destroyOnDeath=false` ile pasif olur)
3. Sahneye ekle:
   - `GameStateController`:
     - `playerHealth` -> Player’daki `Health`
     - `gameOverPanel` varsa ata
   - `HealthSliderUI`:
     - `targetHealth` -> Player’daki `Health`
   - `EnemySpawner`:
     - `enemyPrefab` -> Health’e sahip enemy prefab
     - `spawnPoints` -> spawn olacak Transform noktaları
   - `ScoreManager`:
     - `playerHealth` -> Player’daki `Health` (oyuncu ölümü skor yapmasın diye)
4. Play:
   - Enemy’ler spawn olur
   - Mouse Left ile vurdukça enemy ölür ve skor artar
   - Oyuncu ölünce GameOver tetiklenir

### Restart
- `RestartInput.cs` eklediysen `R` tuşu ile aynı scene yeniden yüklenir.

