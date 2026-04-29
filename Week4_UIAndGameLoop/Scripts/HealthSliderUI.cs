using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Sağlık barını (Slider) Health değerine göre günceller.
/// </summary>
public class HealthSliderUI : MonoBehaviour
{
    public Health targetHealth;
    public Slider slider;

    void Reset()
    {
        // Inspector'da slider atanmadıysa, aynı objede aranır.
        if (slider == null)
            slider = GetComponent<Slider>();
    }

    void Update()
    {
        if (targetHealth == null || slider == null) return;

        float ratio = 0f;
        if (targetHealth.maxHealth > 0f)
            ratio = targetHealth.currentHealth / targetHealth.maxHealth;

        slider.value = Mathf.Clamp01(ratio);
    }
}

