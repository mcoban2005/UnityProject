## Week 1 — Unity Temelleri + FPS İskeleti

### Hedef
Unity’de temel çalışma mantığını oturtmak ve First Person için sahne iskeletini kurmak.

### Öğrenme çıktıları
- `Scene`, `GameObject` ve `Component` ilişkisini kavrarsın
- `Transform` ile obje yerleştirmeyi ve parent-child mantığını uygularsın
- FPS için `Camera` objesini doğru hiyerarşide kullanmayı öğrenirsin
- Play sırasında `Cursor.lockState` ile “FPS imleç davranışı”nı sağlarsın

### Konular
- Scene / GameObject / Component yaklaşımı
- `Transform` (Position, Rotation, Scale) ve parent-child zinciri
- Kamera yerleşimi (head/eye hizası fikri)
- Basic debug (`Debug.Log`) ve script’in sahnede nasıl çalıştığı

### Laboratuvar (adım adım)
1. Unity’de yeni bir sahne aç.
2. `GameObject` -> `Create Empty` ile `Player` isminde bir obje oluştur.
3. `Player` objesinin child’ı olarak `Camera` ekle.
4. `Player`’ı dünyada uygun bir yüksekliğe koy (zemin üstü).
5. `Player` üstüne veya sahnede ayrı bir objeye `CursorLockOnPlay` ekle (Week 1 script’i).
6. Play’e bas ve farenin “kilitlenmiş” davranışını test et.

### Mini Görev (checkpoint)
- Kamera FPS bakışı verecek şekilde sahneye yerleşsin
- Play sırasında cursor kilitlensin (görünmez + hareket imleci kilitli)

### Kontrol Listesi
- [ ] `Player/Camera` hiyerarşisi kuruldu
- [ ] `CursorLockOnPlay` aktif
- [ ] `Scene` Play ile hata vermeden çalışıyor

### Bu hafta eklenecek örnek kodlar
- `Scripts/CursorLockOnPlay.cs`

