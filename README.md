# UnityFPS 5 Haftalık First Person FPS Eğitimi

Bu repo, **Unity 2022 LTS**, **New Input System** ve **CharacterController** kullanarak basit bir **First Person FPS** mini oyun mantığını 5 haftaya yayılmış şekilde öğretir.

## Yapı

- `Week1_IntroUnity/` .. `Week5_CapstoneFPS/` : Haftalık konu içerikleri ve örnek kodlar
- `Week6_PolishWeaponAI/` : Haftalık mini geliştirmeler (weapon/ammo, crosshair, enemy AI)
- `Assets/Input/Player/PlayerControls.inputactions` : Shared Input Actions (New Input System)
- `.gitignore` : Unity için uygun ignore kuralları

## Kullanım (pratik)

- Örnek kodları Unity’de kullanmak istersen, ilgili `Scripts/*.cs` dosyalarını projende `Assets/` altına taşıyabilir veya Unity içinde aynı klasör yapısına koyabilirsin.
- `inputactions` dosyası için Unity tarafında `Input Actions` asset’i oluşturup aynı `Action Map`/`Action` isimleriyle bağlaman gerekebilir (aşağıdaki hafta `README`’lerinde yönlendirme var).

## GitHub’a ekleme
- Bu projede Unity’nin derleme/önbellek çıktıları `.gitignore` ile dışlanır (`Library/`, `Temp/`, `Obj/`, `Build/` vb.).
- Genelde commit etmek istediğin dosyalar:
  - `Week1_...` .. `Week5_...` klasörlerindeki `README.md` ve C# örnekleri
  - `Assets/Input/Player/PlayerControls.inputactions`
  - (varsa) oluşturacağın `Scenes/*.unity` ve Unity proje metin dosyaları
- Unity içinde çalıştırmak için C# dosyalarının derlenebilmesi gerekir; bu nedenle istersen `WeekX_.../Scripts` içindeki `.cs` dosyalarını proje `Assets/` altına taşı.

