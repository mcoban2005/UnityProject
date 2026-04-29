Bu klasörde First Person FPS dersinde kullanılacak **New Input System** action asset bulunur.

Beklenen Action Map:
- `Player`

Beklenen Actions:
- `Move` (Vector2, WASD - 2DVector composite)
- `Look` (Vector2, Mouse Delta)
- `Jump` (Button, Space)
- `Fire` (Button, Mouse Left)

Kullanım:
- Unity 2022 LTS içinde proje `Assets/` altında bu dosyayı gördüğünde otomatik import edilecektir.
- Kod tarafında `InputActionReference` alanlarına (ör. `moveAction`, `lookAction`...) ilgili action’u Inspector’dan seçerek bağlayabilirsin.

