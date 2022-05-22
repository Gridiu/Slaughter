using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private Player _player;
    [SerializeField] private Slider _slider;

    private void OnEnable() => _player.HealthChanged += OnValueChanged;

    private void OnDisable() => _player.HealthChanged -= OnValueChanged;

    private void OnValueChanged(float value, float maxValue) => _slider.value = value / maxValue;
}