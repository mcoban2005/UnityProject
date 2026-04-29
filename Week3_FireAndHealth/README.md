## Week 3 — Raycast ile Ateş Etme + Health

### Hedef
FPS atışını `Raycast` ile “hitscan” tarzında yapmak ve hedefe `Health` üzerinden hasar vermek.

### Öğrenme çıktıları
- FPS’te atışın “raycast/hitscan” mantığını uygularsın
- New Input System ile `Fire` aksiyonunu tespit edip tek atış yapabilirsin
- `Health` üzerinden hasar aktarımını component tabanlı tasarlarsın

### Konular
- Kamera/nişan merkezinden `Raycast`
- `InputActionReference` ile input enable + `WasPressedThisFrame()`
- `Health.TakeDamage()` akışı
- GameObject ölüm davranışı: `destroyOnDeath` veya `SetActive(false)`

### Bu hafta eklenecek örnek kodlar
- `Scripts/Health.cs`
- `Scripts/HitscanShooter.cs`

### Laboratuvar (adım adım)
1. Bir hedef oluştur (ör. Enemy küpü).
2. Hedef objeye `Health` ekle.
   - `maxHealth` ayarla (örn. 50)
   - İstersen `destroyOnDeath=true` yap (istersen default hali olan pasif etmeyi kullan)
3. Player objesine `HitscanShooter` ekle.
4. Inspector’dan bağla:
   - `fireAction` -> `Player/Fire`
   - `firePoint` -> Camera transform’u (tercihen camera)
   - `hitMask` gerekirse sınırlandır
5. Play:
   - Mouse Left ile vur
   - Console’da hasar/ölüm log’unu gör

### Mini Görev (checkpoint)
- [ ] Hedefe ateş edince `currentHealth` azalıyor
- [ ] Health 0 olunca hedef kapanıyor (veya destroy ediliyor)
- [ ] UI yok, sadece debug ve log üzerinden doğruluyorsun


