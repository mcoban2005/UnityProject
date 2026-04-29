## Week 2 — New Input System + First Person Hareket (CharacterController)

### Hedef
WASD ile hareket ve fare ile bakış (yaw/pitch) kontrolünü **New Input System** üzerinden yapmak.

### Konular
- `InputActionAsset` / `InputAction` mantığı
- `InputActionReference` ile aksiyon okuma
- `CharacterController.Move`
- Gravity + basit zıplama

### Mini Görev
- `Move`: WASD ile yürü/geri git
- `Look`: mouse ile başı yukarı/aşağı ve sağa/sola çevir
- `Jump`: Space ile zıplama

### Bu hafta eklenecek örnek kodlar
- `Scripts/FpsInputMovementCC.cs`

### Unity kurulum (kısa)
- Bir `Player` GameObject oluştur ve `CharacterController` ekle.
- Child olarak `Camera` ekle (pitch için bu camera transform kullanılacak).
- `FpsInputMovementCC` script’ini `Player` objesine ekle.
- Inspector’da:
  - `moveAction` -> `Player/Move`
  - `lookAction` -> `Player/Look`
  - `jumpAction` -> `Player/Jump`
  - `cameraTransform` -> child `Camera`

