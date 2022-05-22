using UnityEngine;

[RequireComponent(typeof(PlayerMovement))]
[RequireComponent(typeof(PlayerShooting))]
public class PlayerInputHandler : MonoBehaviour
{
    private PlayerMovement _playerMovement;
    private PlayerShooting _playerShooting;

    private void Start()
    {
        _playerMovement = GetComponent<PlayerMovement>();
        _playerShooting = GetComponent<PlayerShooting>();
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.W))
            _playerMovement.Move(Vector2.up);

        if (Input.GetKey(KeyCode.S))
            _playerMovement.Move(Vector2.down);

        if (Input.GetKey(KeyCode.A))
            _playerMovement.Move(Vector2.left);

        if (Input.GetKey(KeyCode.D))
            _playerMovement.Move(Vector2.right);

        if (Input.GetMouseButton(0))
            _playerShooting.Shoot();
    }
}