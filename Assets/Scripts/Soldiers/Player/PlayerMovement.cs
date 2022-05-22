using UnityEngine;

public class PlayerMovement : SoldierMovement
{
    private void OnEnable() => Game.Restarted += Reset;

    private void Update()
    {
        Vector3 mousePosition = Input.mousePosition;

        Look(mousePosition);
    }

    private void OnDisable() => Game.Restarted -= Reset;

    public override void Look(Vector3 mousePosition)
    {
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);

        base.Look(mousePosition);
    }

    public void Move(Vector3 vector) => transform.position += Speed * Time.deltaTime * vector;

    private void Reset() => transform.SetPositionAndRotation(Vector3.zero, Quaternion.identity);
}