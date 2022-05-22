using System.Linq;
using UnityEngine;

public class BulletPool : ObjectPool
{
    private const float CameraCenteXPosition = 0.5f;
    private const float CameraCenteYPosition = 0.5f;

    private const float DissableFrequency = 2f;

    private Camera _camera;
    private float _distanceToFarthestBoarder;

    private float _disableTimer;

    protected override void Start()
    {
        _camera = Camera.main;
        _distanceToFarthestBoarder = _camera.orthographicSize * _camera.aspect;

        base.Start();
    }

    private void Update()
    {
        _disableTimer += Time.deltaTime;

        if (_disableTimer > DissableFrequency)
        {
            DisableObjectAbroadScreen();

            _disableTimer = 0;
        }
    }

    public override bool TryGetObject(out GameObject result)
    {
        result = Pool.FirstOrDefault(p => p.activeSelf == false);

        return result != null;
    }

    private void DisableObjectAbroadScreen()
    {
        Vector3 disablePoint = _camera.ViewportToWorldPoint(new Vector3(CameraCenteXPosition, CameraCenteYPosition, _camera.transform.position.z));

        foreach (var item in Pool)
        {
            if (item.transform.position.y < disablePoint.y - _distanceToFarthestBoarder ||
                item.transform.position.y > disablePoint.y + _distanceToFarthestBoarder ||
                item.transform.position.x < disablePoint.x - _distanceToFarthestBoarder ||
                item.transform.position.x > disablePoint.x + _distanceToFarthestBoarder)
            {
                item.SetActive(false);
            }
        }
    }
}