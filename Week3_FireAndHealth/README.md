## Week 3 — Raycast ile Ateş Etme + Health

### Hedef
FPS atışını `Raycast` ile “hitscan” tarzında yapmak ve hedefe `Health` üzerinden hasar vermek.

### Konular
- Kamera merkezinden `Raycast`
- `InputAction` ile `Fire`
- `Health` (TakeDamage / öldü durumu)

### Mini Görev
- Mouse Left ile nişan al ve bir hedefe vur
- Vurunca `Health` düşsün
- Health 0 olunca “düştü/öldü” log’u çıksın (istersen destroy)

### Bu hafta eklenecek örnek kodlar
- `Scripts/Health.cs`
- `Scripts/HitscanShooter.cs`

### Unity kurulum (kısa)
- Bir hedef objeye `Health` ekle.
  - `maxHealth` ve `destroyOnDeath` (istersen true) ayarla.
- `HitscanShooter` script’ini Player’a (veya weapon objesine) ekle.
  - `fireAction` -> `Player/Fire`
  - `firePoint` -> Kamera transform’u (yoksa script kendi transform’unu kullanır)


