## Week 5 — Capstone: Mini FPS (Spawn + Skor + Game Over)

### Hedef
Week 2-4’teki parçaları birleştirerek mini bir FPS yapısı kurmak:
- Enemy spawn
- Raycast ile vurma
- Health ile ölüm
- Skor ve Game Over akışı

### Öğrenme çıktıları
- `Instantiate` ile runtime spawn yapmayı öğrenirsin
- Event tabanlı Health ölüm takibi ile skor üretirsin
- GameOver/restart akışını bir araya getirirsin

### Konular
- Spawner mantığı (`Instantiate`, zamanlayıcı)
- Score: Enemy death event’i üzerinden puanlama
- Restart: `SceneManager.LoadScene` (opsiyonel)

### Mini Görev (teslim)
1. Enemy’ler belirli aralıklarla sahneye gelsin
2. Player ateşi ile enemy’ler hasar alıp “ölmüş” sayılabilsin
3. Enemy ölünce skor artsın
4. Oyuncu ölünce GameOver açılsın
5. (Opsiyonel) Restart ile tekrar başlayabilsin

### Bu hafta eklenecek örnek kodlar
- `Scripts/EnemySpawner.cs`
- `Scripts/ScoreManager.cs`
- `Scripts/RestartInput.cs` (opsiyonel)

### Capstone kurulum akışı (kısa)
#### 1) Player (hareket + ateş)
- Player objesinde:
  - `CharacterController`
  - `FpsInputMovementCC`
  - `HitscanShooter` (Week 3) veya Week 6 weapon kullanıyorsan onu
  - Oyuncunun üzerinde `Health` (Health sistemi GameOver’u tetiklemek için gerekli)

#### 2) Enemy prefab
- Enemy prefab üzerinde:
  - `Health` (varsayılan `destroyOnDeath=false` yeterli: `SetActive(false)` ile “ölü” olur)

#### 3) Sahne objeleri
- UI:
  - `HealthSliderUI` -> `targetHealth` Player’daki `Health`
- Game State:
  - `GameStateController` -> `playerHealth` Player’daki `Health` + (opsiyonel) `gameOverPanel`
- Spawn:
  - `EnemySpawner`:
    - `enemyPrefab` -> Health’e sahip enemy prefab
    - `spawnPoints` -> spawn noktaları
- Skor:
  - `ScoreManager`:
    - `playerHealth` -> Player’daki `Health` (oyuncu ölürse skor artmasın diye)

#### 4) Play testi
- Enemy’ler spawn olur
- Player ateş ettikçe enemy’ler hasar alır/ölür
- Enemy ölümünden sonra console’da “Skor” artışı görülür

### Restart
- `RestartInput.cs` eklediysen `R` tuşu ile aynı scene yeniden yüklenir.

### Önemli Not (GameOver tetikleme)
- Bu projedeki `GameStateController`, Health event’lerini dinler ve sadece Inspector’da atanmış `playerHealth` instance’ı ölünce GameOver yapar.
- Bu yüzden Player’a hasar veren bir mekanizma yoksa GameOver tetiklenmeyebilir.
- Week 6’daki `EnemyChaseAI` (veya çok küçük bir “temas hasarı” script’i) ekleyerek Player’a zarar verip GameOver akışını tamamlayabilirsin.

