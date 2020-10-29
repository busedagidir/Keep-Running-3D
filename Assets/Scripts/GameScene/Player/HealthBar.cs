using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Slider _slider;
    
    public void SetMaxHealth(float _startHealth)
    {
        _slider.maxValue = _startHealth;
        _slider.value = _startHealth;
    }

    public void SetHealth(float _startHealth)
    {
        _slider.value = _startHealth;
    }
}
