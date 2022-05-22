using TMPro;
using UnityEngine;

public class Scoring : MonoBehaviour
{
    [SerializeField] private Player _player;
    [SerializeField] private TMP_Text _textField;

    private int point;

    private void OnEnable()
    {
        Enemy.Died += Score;

        _player.Died += Reset;
    }

    private void OnDisable()
    {
        Enemy.Died -= Score;

        _player.Died -= Reset;
    }

    private void Score()
    {
        point++;

        UpdateText();
    }

    private void UpdateText() => _textField.text = point.ToString();

    private void Reset()
    {
        point = 0;

        UpdateText();
    }
}