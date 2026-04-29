## Week 1 — Unity Temelleri + FPS İskeleti

### Hedef
Unity’de temel çalışma mantığını oturtmak ve First Person için sahne iskeletini kurmak.

### Konular
- Scene / GameObject / Component yaklaşımı
- `Transform` (Position, Rotation, Scale)
- Kamera yerleşimi (head/eye hizası fikri)
- Basic debug (`Debug.Log`)

### Mini Görev
- Bir `Player` objesi oluştur.
- Child olarak `Camera` ekle ve birinci şahıs görüşe geç.
- Play anında farenin ekranda kilitlenmesi için `Cursor.lockState` kullan.

### Bu hafta eklenecek örnek kodlar
- `Scripts/CursorLockOnPlay.cs`

### Kurulum (mini not)
- Scene’de boş bir `GameObject` (ör. `GameManager`) oluşturup bu script’i `Add Component` ile ekleyebilirsin.
- Play’e basınca imleç kilitlenmelidir.

