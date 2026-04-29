## Week 2 — New Input System + First Person Hareket (CharacterController)

### Hedef
WASD ile hareket ve fare ile bakış (yaw/pitch) kontrolünü **New Input System** üzerinden yapmak.

### Öğrenme çıktıları
- `PlayerControls.inputactions` içindeki action map’i kodda `InputActionReference` ile kullanırsın
- Fare delta ile yaw/pitch hesaplayıp `CharacterController` ile hareketi birleştirirsin
- `Time.deltaTime` ile hareket hızını frame bağımsız yönetirsin

### Konular
- New Input System: `InputActionAsset`, `action map`, `action types`
- Koddan aksiyon okuma: `InputActionReference.action.Enable()` ve `ReadValue<Vector2>()`
- FPS bakış mantığı: yaw (player yaw) + pitch (camera local pitch)
- `CharacterController.isGrounded` ile gravity/jump entegrasyonu

### Laboratuvar (adım adım)
1. `Assets/Input/Player/PlayerControls.inputactions` dosyasını projende kullandığından emin ol.
2. `Player` objesi:
   - Üzerinde `CharacterController` olsun
   - Child olarak `Camera` olsun (pitch için hedef)
3. Player objesine `FpsInputMovementCC` ekle.
4. Inspector’dan referansları bağla:
   - `moveAction`: `Player/Move`
   - `lookAction`: `Player/Look`
   - `jumpAction`: `Player/Jump`
   - `cameraTransform`: child Camera transform’u
5. Scene’e basit bir `Ground` koy (Plane yeterli).
6. Play:
   - WASD ile hareket
   - Mouse ile bakış
   - Space ile zıplama

### Mini Görev (checkpoint)
- [ ] Bakış yönü (yaw/pitch) düzgün çalışıyor
- [ ] Zıplama sadece yerdeyken tetikleniyor (ground check var)
- [ ] Hareket “takılmadan” akıcı

### Bu hafta eklenecek örnek kodlar (repo içi)
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

### Yaygın Hatalar
- `cameraTransform` atanmazsa pitch çalışmaz.
- `moveAction/lookAction/jumpAction` atamazsan script “null” durumda hiçbir şey yapmaz.

