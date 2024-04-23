using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private Camera _camera;

    private void Awake()
    {
        _camera = Camera.main;
    }

    private void Update()
    {
        DestroyWhenOffScreen();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<EnemyMovement>())
        {
            HealthController healthController = collision.GetComponent<HealthController>();
            healthController.TakeDamamge(10);
            Destroy(gameObject);
        }
    }

    private void DestroyWhenOffScreen()
    {
        Vector2 screenPosistion = _camera.WorldToScreenPoint(transform.position);

        if(screenPosistion.x < 0 || screenPosistion.x > _camera.pixelWidth ||
            screenPosistion.y < 0 || screenPosistion.y > _camera.pixelHeight)
        {
            Destroy(gameObject);
        }
    }
}
