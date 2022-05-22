using UnityEngine;
using UnityEngine.Events;

public class Game : MonoBehaviour
{
    [SerializeField] private Screen _screen;
    [SerializeField] private Player _player;
    [SerializeField] private Scoring _scoring;

    public static UnityAction Restarted;

    private void OnEnable() => _player.Died += End;

    private void Start() => Time.timeScale = 0;

    private void OnDisable() => _player.Died -= End;

    public void Launch()
    {
        if (Time.time > 0)
            Restarted?.Invoke();

        Time.timeScale = 1;

        _screen.gameObject.SetActive(false);
    }

    public void Quit() => Application.Quit();

    private void End()
    {
        Time.timeScale = 0;

        _screen.gameObject.SetActive(true);
    }
}