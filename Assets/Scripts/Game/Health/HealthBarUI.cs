using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBarUI : MonoBehaviour
{
    [SerializeField]
    private UnityEngine.UI.Image _healthBarForgroundImage;
    public void UpdateHealthBar(HealthController healthController)
    {
        _healthBarForgroundImage.fillAmount = healthController.RemainingHealthPercentge;
    }
}
