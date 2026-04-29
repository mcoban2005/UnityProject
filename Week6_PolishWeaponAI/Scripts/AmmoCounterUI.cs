using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Ammo counter UI (Text) günceller.
/// </summary>
public class AmmoCounterUI : MonoBehaviour
{
    public HitscanWeaponAmmo weapon;
    public Text ammoText;

    void Reset()
    {
        if (ammoText == null)
            ammoText = GetComponent<Text>();
    }

    void Update()
    {
        if (weapon == null || ammoText == null) return;

        ammoText.text = $"Ammo: {weapon.CurrentAmmo}/{weapon.ReserveAmmo}";
    }
}

